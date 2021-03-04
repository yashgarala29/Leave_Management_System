using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Leave_Management_System.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Leave_Management_System.Controllers
{
    public class FacultyController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmailService emailService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public FacultyController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager,
            IEmailService emailService, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.signInManager = signInManager;
            this.emailService = emailService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            webHostEnvironment = hostEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Faculty")]
        public IActionResult LeaveRequest()
        {
            ViewBag.leavetype = new SelectList(_context.leaveType.Where(x => x.itispersonal == true && x.allcatoToAll == true), "leaveTypeID", "LeaveType");
            return View();
        }

        [Authorize(Roles = "Faculty")]
        public IActionResult HomePageFaculty()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Faculty")]
        public IActionResult LeaveRequest(LeaveRequest leaveRequest, IFormFile file)
        {
            ViewBag.leavetype = new SelectList(_context.leaveType.Where(x => x.itispersonal == true && x.allcatoToAll == true), "leaveTypeID", "LeaveType");
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (file != null)
                {

                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "file");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                string username = User.Identity.Name;
                var singleUser = _context.AllUser.Where(x => x.Email == username).FirstOrDefault();
                var leaveHistory = new LeaveHistory
                {
                    StartFrome = leaveRequest.LeaveStartFrome,
                    EndTill = leaveRequest.LeaveEndTill,
                    LeaveReason = leaveRequest.LeaveReason,
                    NoOfDay = (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays),
                    DeanApproveStatus = "Pending",
                    HODApproveStatus = "Pending",
                    RegistrarApproveStatus = "Pending",
                    LeaveStatus = "Pending",
                    id = singleUser.id,
                    leaveTypeID = Convert.ToInt32(leaveRequest.LeaveType),
                    Attachment = uniqueFileName
                };
                var leaevupdate = _context.leaveAllocation.Where(x => x.id == singleUser.id && x.leaveTypeID == Convert.ToInt32(leaveRequest.LeaveType)).FirstOrDefault();
                var totaledayinpending = _context.LeaveHistory.Where(x => x.id == singleUser.id && x.StartFrome > DateTime.Now && x.LeaveStatus == "Pending").Select(x => x.NoOfDay).ToList().Sum();

                if ((int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays) > (leaevupdate.NoOfLeave - totaledayinpending))
                {
                    ModelState.AddModelError(string.Empty, "You can not request More than " + (leaevupdate.NoOfLeave - totaledayinpending));
                    return View();
                }
                //leaevupdate.NoOfLeave -=(int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays);
                //_context.leaveAllocation.Update(leaevupdate);

                _context.LeaveHistory.Add(leaveHistory);
                _context.SaveChangesAsync();
                return RedirectToAction("MyLeave", "Faculty");
            }
            return View(leaveRequest);
            }
        [HttpGet]
        [Authorize(Roles = "Faculty")]
        public async Task<IActionResult> MyLeave()
        {
            string curentUser = User.Identity.Name;
            var userlevelist = _context.LeaveHistory.Include(x => x.leaveType).Where(x => x.AllUser.Email == curentUser).ToList();
            List<MyLeave> myLeaves = new List<MyLeave>();
            foreach (var temp in userlevelist)
            {
                int status = DateTime.Compare(temp.StartFrome, DateTime.Now);
                var singleLeave = new MyLeave
                {
                    EndTill = temp.EndTill,
                    LeaveReason = temp.LeaveReason,
                    LeaveStatus = temp.LeaveStatus,
                    leave_id = temp.leave_id,
                    NoOfDay = temp.NoOfDay,
                    StartFrome = temp.StartFrome,
                    Attachment = temp.Attachment,
                    changeable = (status > 0) ? 1 : 0,
                    LeaveType = temp.leaveType.LeaveType,
                };
                myLeaves.Add(singleLeave);
            }
            return View(myLeaves);
        }
        int noofleavealocated;
        [HttpGet]
        [Authorize(Roles = "Faculty")]
        public async Task<IActionResult> UpdateLeave(int leave_id)
        {
           
            if (leave_id == 0)
                return NotFound();
            var leaveHistory = _context.LeaveHistory.Include(x => x.leaveType).Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            //
            if (leaveHistory == null)
            {
                //return RedirectToAction("MyLeave", "Faculty");

                return NotFound();
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "Faculty");
            }
            var leareqyest = new LeaveRequest
            {
                id = leaveHistory.leave_id,
                LeaveEndTill = leaveHistory.EndTill,
                LeaveReason = leaveHistory.LeaveReason,
                LeaveStartFrome = leaveHistory.StartFrome,
                LeaveType = leaveHistory.leaveType.LeaveType,
                FileName = leaveHistory.Attachment

            };
            ViewBag.leavetype = new SelectList(_context.leaveType.Where(x => x.itispersonal == true && x.allcatoToAll == true), "leaveTypeID", "LeaveType");

            //ViewBag.leave = leave_id;
            return View(leareqyest);

        }
        public bool convertleavetype(string newvalue, string oldvalue, int noofday, int oldday)
        {
            int sum = 0;
            var z = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
                .Where(x => x.leaveType.LeaveType == oldvalue && x.AllUser.Email == User.Identity.Name).FirstOrDefault();
            z.NoOfLeave += oldday;
            sum = z.NoOfLeave;
            if (sum < noofday)
            {
                return false;
            }
            //_context.Update(z);

            //var y = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
            //   .Where(x => x.leaveType.leaveTypeID == Convert.ToInt32(newvalue) && x.AllUser.Email == User.Identity.Name).FirstOrDefault();
            //y.NoOfLeave =sum- noofday;
            //_context.Update(y);
            //_context.SaveChanges();
            return true;
        }
        [HttpPost]
        [Authorize(Roles = "Faculty")]
        public async Task<IActionResult> UpdateLeave(int id, LeaveRequest leaveRequest,IFormFile file)
        {
            int leave_id = id;
            if (leave_id == 0)
                return NotFound();
            var leaveHistory = _context.LeaveHistory.Include(l => l.AllUser)
                .Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            if (leaveHistory == null)
            {
                return NotFound();
                //return RedirectToAction("MyLeave", "Faculty");
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "Faculty");
            }
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (file != null)
                {

                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "file");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                try
                {
                    var oldallocatedleave = _context.leaveAllocation.Include(x => x.leaveType).Where(x => x.id == leaveHistory.id && x.leaveTypeID == leaveHistory.leaveTypeID).FirstOrDefault();

                    var statusOfAllocation = convertleavetype(leaveRequest.LeaveType, oldallocatedleave.leaveType.LeaveType, (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays), leaveHistory.NoOfDay);
                    if (!statusOfAllocation)
                    {
                        ModelState.AddModelError(string.Empty, "You can not request More than " + oldallocatedleave.NoOfLeave + leaveHistory.NoOfDay);
                        return View(leaveRequest);
                    }
                    if (leaveHistory.LeaveStatus == "Approve")
                    {
                        readdleave(leaveHistory.leaveType.LeaveType, leaveHistory.NoOfDay);
                    }
                    leaveHistory.LeaveReason = leaveRequest.LeaveReason;
                    leaveHistory.LeaveStatus = "Pending";
                    leaveHistory.HODApproveStatus = "Pending";
                    leaveHistory.EndTill = leaveRequest.LeaveEndTill;
                    leaveHistory.StartFrome = leaveRequest.LeaveStartFrome;
                    leaveHistory.leaveTypeID = Convert.ToInt32(leaveRequest.LeaveType);
                    leaveHistory.NoOfDay = (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays);
                    leaveHistory.Attachment = uniqueFileName;
                    var HODuser = _context.AllUser.Where(x => x.Role == "HOD" && x.Deparment == leaveHistory.AllUser.Deparment).FirstOrDefault();
                    _context.Update(leaveHistory);
                    await _context.SaveChangesAsync();

                    UserEmail userEmail = new UserEmail
                    {
                        ToEmail = HODuser.Email,

                    };
                    var arr = new List<KeyValuePair<string, string>>();
                    var temp = new KeyValuePair<string, string>("{{username}}", leaveHistory.AllUser.Email);
                    var StaringDate = new KeyValuePair<string, string>("{{startfrome}}", leaveRequest.LeaveStartFrome.ToLongDateString());
                    var TillDate = new KeyValuePair<string, string>("{{endtill}}", leaveRequest.LeaveEndTill.ToLongDateString());

                    //temp.Key = "username";
                    //temp.Value = "yashgarala29@gmail.com";
                    arr.Add(temp);
                    arr.Add(StaringDate);
                    arr.Add(TillDate);
                    userEmail.PlaceHolder = arr;
                    await emailService.SendLeaveUpdateEmail(userEmail);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction("MyLeave", "Faculty");
            };
            return View();
        }

        public bool addtoallocation(string oldvalue, int noofday)
        {
            int sum = 0;
            var z = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
                .Where(x => x.leaveType.LeaveType == oldvalue && x.AllUser.Email == User.Identity.Name).FirstOrDefault();
            z.NoOfLeave -= noofday;
            _context.Update(z);
            _context.SaveChanges();
            return true;
        }
        [HttpGet]
        [Authorize(Roles = "Faculty")]
        public async Task<IActionResult> DeleteLeave(int leave_id)
        {
            if (leave_id == 0)
                return RedirectToAction("MyLeave", "Faculty");
            //return NotFound();
            var leaveHistory = _context.LeaveHistory.Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            if (leaveHistory == null)
            {
                return NotFound();
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "Faculty");
            }
            DeleteLeave deleteLeave = new DeleteLeave
            {
                LeaveEndTill = leaveHistory.EndTill,
                LeaveStatus = leaveHistory.LeaveStatus,
                LeaveReason = leaveHistory.LeaveReason,
                LeaveStartFrome = leaveHistory.StartFrome,
                leave_id = leaveHistory.leave_id,
                NoOfDay = leaveHistory.NoOfDay,
            };
            ViewBag.id = leave_id;
            return View(deleteLeave);
        }
        public bool readdleave(string oldvalue, int noofday)
        {
            int sum = 0;
            var z = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
                .Where(x => x.leaveType.LeaveType == oldvalue && x.AllUser.Email == User.Identity.Name).FirstOrDefault();
            z.NoOfLeave += noofday;
            _context.Update(z);
            _context.SaveChanges();
            return true;
        }
        [HttpPost]
        [Authorize(Roles = "Faculty")]
        public async Task<IActionResult> DeleteLeave(int leave_id, DeleteLeave deleteLeave)
        {
            //var leaveHistory = await _context.LeaveHistory.FindAsync(leave_id && m.AllUser.Email == User.Identity.Name);
            var leaveHistory = await _context.LeaveHistory
                .Include(l => l.AllUser).Include(l => l.leaveType)
                .FirstOrDefaultAsync(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name);

            if (leaveHistory == null)
                return NotFound();
            var HODuser = _context.AllUser.Where(x => x.Role == "HOD" && x.Deparment == leaveHistory.AllUser.Deparment).FirstOrDefault();
            //if(HODuser==null)

            UserEmail userEmail = new UserEmail
            {
                ToEmail = (HODuser != null) ? HODuser.Email : "yashgarala29@gmail.com",

            };
            var arr = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>("{{username}}", leaveHistory.AllUser.Email);
            if (leaveHistory.LeaveStatus == "Accept")
                readdleave(leaveHistory.leaveType.LeaveType, leaveHistory.NoOfDay);
            //temp.Key = "username";
            //temp.Value = "yashgarala29@gmail.com";
            arr.Add(temp);
            userEmail.PlaceHolder = arr;
            await emailService.SendLeaveCancelEmail(userEmail);
            //addtoallocation(leaveHistory.leaveType.LeaveType, leaveHistory.NoOfDay);
            _context.LeaveHistory.Remove(leaveHistory);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyLeave", "Faculty");
        }

    }
}