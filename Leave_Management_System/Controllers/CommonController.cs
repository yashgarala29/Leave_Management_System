using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Leave_Management_System.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class CommonController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IEmailService emailService;

        public CommonController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
            webHostEnvironment = hostEnvironment;
        }

        static OwnProfile ownProfile_transfer;
        [HttpGet]
        [Authorize(Roles = "Pending,Dean,Faculty,admin,HOD,Registrar")]
        public IActionResult OwnProfile()
        {
            var userLoginDetail = userManager.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            var userdetail = _context.AllUser.Where(x => x.Email == userLoginDetail.Email).FirstOrDefault();

            OwnProfile ownProfile = new OwnProfile
            {
                id = userdetail.id,
                LastName = userdetail.LastName,
                Addreaddress = userdetail.Addreaddress,
                Email = userdetail.Email,
                City = userdetail.City,
                MiddleName = userdetail.MiddleName,
                MobileNo = userdetail.MobileNo,
                MobileNo2 = userdetail.MobileNo2,
                Name = userdetail.Name,
                PaidLeave = userdetail.PaidLeave,
                Department = userdetail.Deparment,
                Role = userdetail.Role,
                ExistingImage = userdetail.UserImage
            };
            ownProfile_transfer = ownProfile;
            return View(ownProfile);
        }
        [HttpPost]
        [Authorize(Roles = "Pending,Dean,Faculty,admin,HOD,Registrar")]
        public async Task<IActionResult> OwnProfile(OwnProfile ownProfile)
        {
            //var userLoginDetail = userManager.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            //var userdetail = _context.AllUser.Where(x => x.Email == userLoginDetail.Email).FirstOrDefault();
            if (ModelState.IsValid)
            {

                string uniqueFileName = ProcessUploadedFile(ownProfile);
                AllUser allUser = new AllUser
                {
                    id = ownProfile.id,
                    LastName = ownProfile.LastName,
                    Addreaddress = ownProfile.Addreaddress,
                    Email = User.Identity.Name,
                    City = ownProfile.City,
                    MiddleName = ownProfile.MiddleName,
                    MobileNo = ownProfile.MobileNo.ToString(),
                    MobileNo2 = ownProfile.MobileNo2.ToString(),
                    Name = ownProfile.Name,
                    PaidLeave = ownProfile_transfer.PaidLeave,
                    Deparment = ownProfile_transfer.Department,
                    Role = ownProfile_transfer.Role,
                    UserImage = uniqueFileName
                };

                try
                {

                    _context.Update(allUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(controllerName: "common", actionName: "OwnProfile");
                }
                catch (DbUpdateConcurrencyException)
                {

                    return View(ownProfile);

                }


            }

            return View(ownProfile);
        }



        private string ProcessUploadedFile(OwnProfile ownProfile)
        {
            string uniqueFileName = null;

            if (ownProfile.EmployeePicture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ownProfile.EmployeePicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ownProfile.EmployeePicture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }


        [HttpGet]
        [Authorize(Roles = "Dean,admin,HOD,Registrar")]
        public async Task<IActionResult> ListLeaveAllocation()
        {
            var loginuser = User.Identity.Name;
            var curentuser = await _context.AllUser.Where(x => x.Email == loginuser).FirstOrDefaultAsync();
            List<LeaveAllocation> listof;
            if (curentuser.Role == "HOD")
            {
                listof = await _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType)
                   .Where(y => y.AllUser.Role == "Faculty" && y.AllUser.Deparment == curentuser.Deparment).ToListAsync();

            }
            else if (curentuser.Role == "Dean")
            {
                listof = await _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType)
                   .Where(y => y.AllUser.Role == "HOD").ToListAsync();

            }
            else if (curentuser.Role == "Registrar")
            {
                listof = await _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType)
                                   .Where(y => y.AllUser.Role == "Dean").ToListAsync();

            }
            else
            {
                listof = new List<LeaveAllocation>();
            }
            return View(listof);
        }


        [HttpGet]
        [Authorize(Roles = "Dean,admin,HOD,Registrar,Faculty")]
        public async Task<IActionResult> ListUserLeaveAllocation()
        {
            string curentUser = User.Identity.Name;
            //var LeaveTypeName = _context.LeaveHistory.Include(x => x.leaveType.LeaveType).Where(x => x.AllUser.Email == curentUser);
            var userlevelist = _context.leaveAllocation.Include(x => x.leaveType).Where(x => x.AllUser.Email == curentUser);
            //var leaveDbContext = _context.leaveAllocation.Include(l => l.AllUser);
            return View(await userlevelist.ToListAsync());
        }
        [HttpGet]
        [Authorize(Roles = "Dean,admin,HOD,Registrar")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var allUser1 = await _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser).Where(x => x.AllocationID == id).FirstOrDefaultAsync();
            if (allUser1 == null)
            {
                return NotFound();
            }
            var loginuser = User.Identity.Name;
            var curentuser = await _context.AllUser.Where(x => x.Email == loginuser).FirstOrDefaultAsync();
            List<LeaveAllocation> listof;
            if (curentuser.Role == "HOD" && allUser1.AllUser.Role == "Faculty" && allUser1.AllUser.Deparment == curentuser.Deparment)
            {
                return View(allUser1);

            }
            else if (curentuser.Role == "Dean" && allUser1.AllUser.Role == "HOD")
            {
                return View(allUser1);
            }
            else if (curentuser.Role == "Registrar" && allUser1.AllUser.Role == "Dean")
            {
                return View(allUser1);

            }
            else
            {
                return RedirectToAction("", "");

            }

        }

        [HttpPost]
        [Authorize(Roles = "Dean,admin,HOD,Registrar")]
        public async Task<IActionResult> Edit(int? id, LeaveAllocation leaveAllocation)
        {

            if (id == null)
            {
                return NotFound();
            }
            var allUser1 = await _context.leaveAllocation.Include(x => x.leaveType).Include(x => x.AllUser).Where(x => x.AllocationID == id).FirstOrDefaultAsync();
            if (allUser1 == null)
            {
                return NotFound();
            }
            var loginuser = User.Identity.Name;
            var curentuser = await _context.AllUser.Where(x => x.Email == loginuser).FirstOrDefaultAsync();
            List<LeaveAllocation> listof;
            if (curentuser.Role == "HOD" && allUser1.AllUser.Role == "Faculty" && allUser1.AllUser.Deparment == curentuser.Deparment)
            {
                allUser1.NoOfLeave = leaveAllocation.NoOfLeave;
                _context.Update(allUser1);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListLeaveAllocation", "Common");

            }
            else if (curentuser.Role == "Dean" && allUser1.AllUser.Role == "HOD")
            {
                allUser1.NoOfLeave = leaveAllocation.NoOfLeave;
                _context.Update(allUser1);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListLeaveAllocation", "Common");
            }
            else if (curentuser.Role == "Registrar" && allUser1.AllUser.Role == "Dean")
            {
                allUser1.NoOfLeave = leaveAllocation.NoOfLeave;
                _context.Update(allUser1);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListLeaveAllocation", "Common");

            }
            else
            {
                return RedirectToAction("", "");

            }

        }


        [HttpPost]
        [Authorize]
        public string GetUserImage()
        {
            string UserImage = null;
            var Image = _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefault().UserImage;
            if (Image == null)
            {
                UserImage = "/Alternate_image/index.jpg";

            }
            else
            {
                UserImage = "/Uploads/" + Image;

            }
            return (UserImage);
        }

        [HttpGet]
        [Authorize(Roles = "HOD,Registrar,Dean,admin")]
        public async Task<IActionResult> MyLeaveOperation(

            string sortOrder,
        string currentFilter,
        string searchString,
        int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["LeaveStatusSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LeaveStatus_desc" : "";
            ViewData["LeaveReasonSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LeaveReason_desc" : "";
            ViewData["NoOfDaySortParm"] = String.IsNullOrEmpty(sortOrder) ? "NoOfDay_desc" : "";
            ViewData["StartFromeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "StartFrome_desc" : "";
            ViewData["EndTillSortParm"] = String.IsNullOrEmpty(sortOrder) ? "EndTill_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {

                searchString = currentFilter;
            }


            var curentuser = await _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefaultAsync();
            var allusers = from s in _context.LeaveHistory.Include(l => l.AllUser).Include(x => x.leaveType)
                   .Where(y => y.approved_id == curentuser.id)
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                allusers = allusers.Where(s => s.LeaveStatus.Contains(searchString)
                    || s.LeaveReason.Contains(searchString)
                    || s.NoOfDay.ToString().Contains(searchString)
                    || s.EndTill.ToString().Contains(searchString)
                    );
            }

            switch (sortOrder)
            {
                case "LeaveStatus_desc":
                    allusers = allusers.OrderByDescending(s => s.LeaveStatus);
                    break;

                case "LeaveReason_desc":
                    allusers = allusers.OrderByDescending(s => s.LeaveReason);
                    break;

                case "NoOfDay_desc":
                    allusers = allusers.OrderByDescending(s => s.NoOfDay);
                    break;

                case "StartFrome_desc":
                    allusers = allusers.OrderByDescending(s => s.StartFrome);
                    break;

                case "EndTill_desc":
                    allusers = allusers.OrderByDescending(s => s.EndTill);
                    break;

                default:
                    allusers = allusers.OrderBy(s => s.LeaveStatus);
                    break;
            }
            //return View(await allusers.AsNoTracking().ToListAsync());
            int pageSize = 5;
            return View(await PaginatedList<LeaveHistory>.CreateAsync(allusers.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        // GET: LeaveHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveHistory = await _context.LeaveHistory
                .Include(l => l.AllUser)
                .FirstOrDefaultAsync(m => m.leave_id == id);
            if (leaveHistory == null)
            {
                return NotFound();
            }

            return View(leaveHistory);


        }
    }
}
