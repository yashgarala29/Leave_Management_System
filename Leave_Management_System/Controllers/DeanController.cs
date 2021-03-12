using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Leave_Management_System.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Leave_Management_System.Controllers
{
    public class DeanController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IEmailService emailService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        public DeanController(LeaveDbContext context,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager, IEmailService emailService , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.signInManager = signInManager;
            this.emailService = emailService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            webHostEnvironment = hostEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Dean")]
        public IActionResult LeaveRequest()
        {
            ViewBag.leavetype = new SelectList(_context.leaveType.Where(x => x.itispersonal == true && x.allcatoToAll == true), "leaveTypeID", "LeaveType");

            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Dean")]
        public async Task<IActionResult> HomePageDean()
        {
            var curentuseremail = User.Identity.Name;
            var curentuser = await _context.AllUser.Where(x => x.Email == curentuseremail).FirstOrDefaultAsync();
            var leavedata = await _context.LeaveHistory.Include(x => x.AllUser)
                .Include(x => x.leaveType).Where(x => x.AllUser.Role == "HOD").ToListAsync();
            var succesleavecount = leavedata.Where(x => x.LeaveStatus == "Accepted").Count();
            var pandingleavecount = leavedata.Where(x => x.LeaveStatus == "Pending" && x.StartFrome > DateTime.Now).Count();
            var Rejectedleavecount = leavedata.Count() - succesleavecount - pandingleavecount;
            var TotalLeaveCount = succesleavecount + pandingleavecount + Rejectedleavecount;
            var newhomepageviewmodel = new HomePageDatapass
            {
                approveleave = succesleavecount,
                Peandingeave = pandingleavecount,
                Rejectedleave = Rejectedleavecount,
                TotalLeave = TotalLeaveCount
            };
            return View(newhomepageviewmodel);
        }

        [HttpPost]
        [Authorize(Roles = "Dean")]
        public IActionResult LeaveRequest(LeaveRequest leaveRequest, IFormFile file)
        {
            ViewBag.leavetype = new SelectList(_context.leaveType.Where(x => x.itispersonal == true && x.allcatoToAll == true), "leaveTypeID", "LeaveType");
            if(ModelState.IsValid)
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
                _context.LeaveHistory.Add(leaveHistory);
            _context.SaveChangesAsync();
             return RedirectToAction("MyLeave", "Dean");
            }
            return View(leaveRequest);
        }
        

        [HttpGet]
        [Authorize(Roles = "Dean")]
        public async Task<IActionResult> ListOfLeaveRequest()
        {
            var hodDeparment = _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            List<LeaveHistory> leaveHistories = new List<LeaveHistory>();
            var t = await userManager.GetUsersInRoleAsync("HOD");
            foreach (var temp in t)
            {
                var requestedleave = _context.LeaveHistory.Include(l => l.AllUser)
                .Where(x => (x.AllUser.Email == temp.Email && x.DeanApproveStatus == "Pending")).ToList();
                if (requestedleave != null)
                    foreach (var single in requestedleave)
                        leaveHistories.Add(single);
            }

            var allrequest = new List<ListOfLeaveRequestHOD>();
            for (int i = 0; i < leaveHistories.Count; i++)
            {
                var listre = new ListOfLeaveRequestHOD
                {
                    id = leaveHistories[i].leave_id,
                    FirstName = leaveHistories[i].AllUser.Name,
                    LastName = leaveHistories[i].AllUser.LastName,
                    LeaveEndTill = leaveHistories[i].EndTill,
                    LeaveReason = leaveHistories[i].LeaveReason,
                    LeaveStartFrome = leaveHistories[i].StartFrome,
                    NoOfDay = leaveHistories[i].NoOfDay,
                    username = leaveHistories[i].AllUser.Email,
                    Attachment = leaveHistories[i].Attachment,
                    Status = Enum.GetNames(typeof(Status)).ToList()
                };
                allrequest.Add(listre);
            }
            return View(allrequest);
        }
        [HttpPost]
        [Authorize(Roles = "Dean")]
        public async Task<JsonResult> AjaxMethod(string name, string leave_id)
        {

            var currentuser = User.Identity.Name;
            var currentuserId = _context.AllUser.Where(x => x.Email == currentuser).FirstOrDefault().id;



            int leave_id_int = int.Parse(leave_id);
            var leave = _context.LeaveHistory.Where(x => x.leave_id == leave_id_int).FirstOrDefault();
            leave.DeanApproveStatus = name;
            leave.LeaveStatus = name;
            leave.approved_id = currentuserId;

            UserEmail userEmail = new UserEmail
            {
                ToEmail = leave.AllUser.Email,

            };
            var arr = new List<KeyValuePair<string, string>>();
            var leavereason = new KeyValuePair<string, string>("{{leavereason}}", leave.LeaveReason);
            var leavestart = new KeyValuePair<string, string>("{{leavestart}}", leave.StartFrome.ToString());
            var leaveend = new KeyValuePair<string, string>("{{leaveend}}", leave.EndTill.ToString());
            var leavetype = new KeyValuePair<string, string>("{{leavetype}}", leave.leaveType.LeaveType);
            var leavestatus = new KeyValuePair<string, string>("{{leavestatus}}", leave.LeaveStatus);

            //temp.Key = "username";
            //temp.Value = "yashgarala29@gmail.com";
            arr.Add(leavereason);
            arr.Add(leavestart);
            arr.Add(leaveend);
            arr.Add(leavetype);
            arr.Add(leavestatus);
            userEmail.PlaceHolder = arr;
            await emailService.LeaveStatusChangeEmail(userEmail);
            if (name == "Accepted")
            {
                var allocation = _context.leaveAllocation.Include(x => x.AllUser).Include(x => x.leaveType).Where(x => x.id == leave.id && x.leaveTypeID == leave.leaveTypeID).FirstOrDefault();
                allocation.NoOfLeave -= leave.NoOfDay;
                _context.Update(allocation);
                _context.SaveChanges();

            }
            //try
            //{
            _context.Update(leave);
            await _context.SaveChangesAsync();
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}


            



            return Json(leave);
        }
        public bool convertleavetype(string email,string newvalue, string oldvalue, int noofday, int oldday)
        {
            int sum = 0;
            var z = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
                .Where(x => x.leaveType.LeaveType == oldvalue && x.AllUser.Email == email).FirstOrDefault();
            z.NoOfLeave += oldday;
            sum = z.NoOfLeave;
            if (sum < noofday)
            {
                return false;
            }
            return true;
        }
        public bool addtoallocation(string email,string oldvalue, int noofday)
        {
            int sum = 0;
            var z = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
                .Where(x => x.leaveType.LeaveType == oldvalue && x.AllUser.Email == email).FirstOrDefault();
            z.NoOfLeave -= noofday;
            _context.Update(z);
            _context.SaveChanges();
            return true;
        }

        int noofleavealocated;
        [HttpGet]
        [Authorize(Roles = "Dean")]
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
                return RedirectToAction("MyLeave", "Dean");
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
        [HttpGet]
        [Authorize(Roles = "Dean")]
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
                    LeaveType = temp.leaveType.LeaveType,
                    leave_id = temp.leave_id,
                    NoOfDay = temp.NoOfDay,
                    StartFrome = temp.StartFrome,
                    Attachment = temp.Attachment,
                    changeable = (status > 0) ? 1 : 0,
                };
                myLeaves.Add(singleLeave);
            }
            return View(myLeaves);
        }
        [HttpPost]
        [Authorize(Roles = "Dean")]
        public async Task<IActionResult> UpdateLeave(int id, LeaveRequest leaveRequest, IFormFile file)
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
                return RedirectToAction("MyLeave", "Dean");
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

                    var statusOfAllocation = convertleavetype(leaveHistory.AllUser.Email,leaveRequest.LeaveType, oldallocatedleave.leaveType.LeaveType, (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays), leaveHistory.NoOfDay);
                    if (!statusOfAllocation)
                    {
                        ModelState.AddModelError(string.Empty, "You can not request More than " + oldallocatedleave.NoOfLeave + leaveHistory.NoOfDay);
                        return View(leaveRequest);
                    }
                    if (leaveHistory.LeaveStatus == "Accepted")
                    {
                        //await readdleave(leaveHistory.AllUser.Email, leaveHistory.leaveType.LeaveType, leaveHistory.NoOfDay);
                    }
                    leaveHistory.LeaveReason = leaveRequest.LeaveReason;
                    leaveHistory.LeaveStatus = "Pending";
                    leaveHistory.RegistrarApproveStatus = "Pending";
                    leaveHistory.EndTill = leaveRequest.LeaveEndTill;
                    leaveHistory.StartFrome = leaveRequest.LeaveStartFrome;
                    leaveHistory.leaveTypeID = Convert.ToInt32(leaveRequest.LeaveType);
                    leaveHistory.NoOfDay = (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays);
                    leaveHistory.Attachment = uniqueFileName;
                    var HODuser = _context.AllUser.Where(x => x.Role == "Registrar").FirstOrDefault();
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
                return RedirectToAction("MyLeave", "Dean");
            };
            return View();
        }


        [HttpGet]
        [Authorize(Roles = "Dean")]
        public async Task<IActionResult> DeleteLeave(int leave_id)
        {
            if (leave_id == 0)
                return RedirectToAction("MyLeave", "Dean");
            //return NotFound();
            var leaveHistory = _context.LeaveHistory.Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            if (leaveHistory == null)
            {
                return NotFound();
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "Dean");
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
        public async Task<bool> readdleave(string email, string oldvalue, int noofday)
        {
            int sum = 0;
            var z = _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser)
                .Where(x => x.leaveType.LeaveType == oldvalue && x.AllUser.Email == email).FirstOrDefault();
            z.NoOfLeave = z.NoOfLeave+ noofday;
            _context.Update(z);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpPost]
        [Authorize(Roles = "Dean")]
        public async Task<IActionResult> DeleteLeave(int leave_id, DeleteLeave deleteLeave)
        {
            //var leaveHistory = await _context.LeaveHistory.FindAsync(leave_id && m.AllUser.Email == User.Identity.Name);
            var leaveHistory = await _context.LeaveHistory
                .Include(l => l.AllUser).Include(l => l.leaveType)
                .FirstOrDefaultAsync(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name);

            if (leaveHistory == null)
                return NotFound();
            var Deanuser = _context.AllUser.Where(x => x.Role == "Registrar" ).FirstOrDefault();
            //if(HODuser==null)

            UserEmail userEmail = new UserEmail
            {
                ToEmail = (Deanuser != null) ? Deanuser.Email : "yashgarala29@gmail.com",

            };
            var arr = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>("{{username}}", leaveHistory.AllUser.Email);
            if (leaveHistory.LeaveStatus == "Accepted")
                readdleave(leaveHistory.AllUser.Email,leaveHistory.leaveType.LeaveType, leaveHistory.NoOfDay);
            //temp.Key = "username";
            //temp.Value = "yashgarala29@gmail.com";
            arr.Add(temp);
            userEmail.PlaceHolder = arr;
            await emailService.SendLeaveCancelEmail(userEmail);
            //addtoallocation(leaveHistory.leaveType.LeaveType, leaveHistory.NoOfDay);
            _context.LeaveHistory.Remove(leaveHistory);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyLeave", "Dean");
        }

    }
}
