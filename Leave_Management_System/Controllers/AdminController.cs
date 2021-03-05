using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Leave_Management_System.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly LeaveDbContext _context;

        public AdminController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ListOfLeaveRequest()
        {
            var hodDeparment = _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            List<LeaveHistory> leaveHistories = new List<LeaveHistory>();
            var t = await userManager.GetUsersInRoleAsync("Registrar");
            foreach (var temp in t)
            {
                var requestedleave = _context.LeaveHistory.Include(l => l.AllUser)
                .Where(x => (x.AllUser.Email == temp.Email && x.LeaveStatus == "Pending")).ToList();
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
                    Status = Enum.GetNames(typeof(Status)).ToList()
                };
                allrequest.Add(listre);
            }
            return View(allrequest);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<JsonResult> AjaxMethod(string name, string leave_id)
        {

            var currentuser = User.Identity.Name;
            var currentuserId = _context.AllUser.Where(x => x.Email == currentuser).FirstOrDefault().id;



            int leave_id_int = int.Parse(leave_id);
            var leave = _context.LeaveHistory.Where(x => x.leave_id == leave_id_int).FirstOrDefault();
            leave.DeanApproveStatus = name;
            leave.LeaveStatus = name;



            leave.approved_id = currentuserId;
            if (name == "Accepted")
            {
                var allocation = _context.leaveAllocation.Where(x => x.id == leave.id && x.leaveTypeID == leave.leaveTypeID).FirstOrDefault();
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


        [HttpPost]
        public async Task<List<LeaveHistory>> GetLeaveReposrt(string staringDate,string endingDate)
        {
            DateTime staringDate_new = DateTime.Parse(staringDate);

            //var staringDate_new = DateTime.Parse(staringDate);
            //DateTime staringDate_new = Convert.ToDateTime(staringDate);
            DateTime endingDate_new = DateTime.Parse(endingDate);

            //var query = from b in _context.AllUser
            //            join p in _context.LeaveHistory
            //            on b.id equals p.id into grouping
            //            from p in grouping.DefaultIfEmpty()
            //            select new {
            //                id = b.id,
            //                email = b.Email,
            //                Role = b.Role,
            //                leavereason = p.LeaveReason,
            //                leavestaring=p.StartFrome,
            //                leaveending=p.EndTill,
            //                noofday=p.NoOfDay,

            //            };
            var ans = await _context.LeaveHistory.Include(x => x.AllUser).Where(x => (x.EndTill > staringDate_new)
                && (x.StartFrome < endingDate_new)).ToListAsync();
            //string ans = "";
            return ans;
        }

        [HttpGet]
        public IActionResult LeaveReport()
        {
            return View();
        }
        [HttpPost]
        public async Task<bool> Delete(string id)
        {
            int x = Convert.ToInt32(id);
            var deletetype = await _context.leaveType.FindAsync(x);
            _context.leaveType.Remove(deletetype);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpPost]
        public async Task<bool> AllocattoAll(string id)
        {
            int x = Convert.ToInt32(id);
            return await leaveallocationToALL(x);
        }
        public async Task<bool> leaveallocationToALL(int id)
        {
            var alluser_list = await _context.AllUser.Where(x=>x.id>0).ToListAsync();
            var leavetype = await _context.leaveType.FindAsync(id);
            if (leavetype == null)
            {
                return false;
            }
            try{
                for (int i = 0; i < alluser_list.Count; i++)
                {
                    var leavealocation = new LeaveAllocation
                    {
                        id = alluser_list[i].id,
                        NoOfLeave = leavetype.noofday,
                        leaveTypeID = leavetype.leaveTypeID,

                    };
                   

                   
                    _context.leaveAllocation.Add(leavealocation);
                    await _context.SaveChangesAsync();
                }
                leavetype.allcatoToAll = true;
                _context.leaveType.Update(leavetype);
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                var x = e;
                return  false;
            }
            return true;
        }
        //[Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult CreatLeaveType()
        {

            return View();
        }
        
        //[Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> CreatLeaveType(leaveType leave)
        {
            if (ModelState.IsValid)
            {
                _context.leaveType.Add(leave);
                await _context.SaveChangesAsync();
                if(leave.allcatoToAll)
                {
                    var status=await leaveallocationToALL(_context.leaveType.Where(x=>x.LeaveType==leave.LeaveType).FirstOrDefault().leaveTypeID);
                    if(!status)
                    {
                        ViewBag.failmess = "Leave allocation Faile";
                        return View(leave);
                    }
                }
                ViewBag.succesmess = "Leave is Added";
                return View();

            }
            ViewBag.failmess = "Leave is Not Added";
            return RedirectToAction(nameof(ListLeaveType));
        }

        [HttpGet]
        public async Task<IActionResult> ListLeaveType(string sortOrder,
        string currentFilter,
        string searchString,
        int? pageNumber)
        {
                ViewData["CurrentSort"] = sortOrder;
                ViewData["LeaveTypeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LeaveType_desc" : "";
                ViewData["noofdaySortParm"] = String.IsNullOrEmpty(sortOrder) ? "noofday_desc" : "";
                ViewData["allcatoToAllSortParm"] = String.IsNullOrEmpty(sortOrder) ? "allcatoToAll_desc" : "";
                ViewData["itispersonalSortParm"] = String.IsNullOrEmpty(sortOrder) ? "itispersonal_desc" : "";
                
                ViewData["CurrentFilter"] = searchString;

                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    //searchString = "Enter some value";
                    searchString = currentFilter;
                }



                var allusers = from s in _context.leaveType select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    allusers = allusers.Where(s => s.LeaveType.Contains(searchString)
                    || s.noofday.ToString().Contains(searchString)
                    );
                }

                switch (sortOrder)
                {
                    case "LeaveType_desc":
                        allusers = allusers.OrderByDescending(s => s.LeaveType);
                        break;

                    case "noofday_desc":
                        allusers = allusers.OrderByDescending(s => s.noofday);
                        break;

                    case "allcatoToAll_desc":
                        allusers = allusers.OrderByDescending(s => s.allcatoToAll);
                        break;

                    case "itispersonal_desc":
                        allusers = allusers.OrderByDescending(s => s.itispersonal);
                        break;

                   
                    default:
                        allusers = allusers.OrderBy(s => s.LeaveType);
                        break;
                }
                //return View(await allusers.AsNoTracking().ToListAsync());
                int pageSize = 5;
                return View(await PaginatedList<leaveType>.CreateAsync(allusers.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> UpdateLeaveType(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leavetype = await _context.leaveType.FindAsync(id);
            if (leavetype == null)
            {
                return NotFound();
            }
            return View(leavetype);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateLeaveType(int id,leaveType leave )
        {
            if (id != leave.leaveTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leave);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypeExists(leave.leaveTypeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListLeaveType));
            }
            return View(leave);
        }

       
       

        private bool LeaveTypeExists(int id)
        {
            return _context.leaveType.Any(e => e.leaveTypeID == id);
        }
    }
}
