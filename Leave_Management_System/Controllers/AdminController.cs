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
            return View(leave);
        }

        [HttpGet]
        public async Task<IActionResult> ListLeaveType()
        {
            return View(await _context.leaveType.ToListAsync());
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
                return RedirectToAction(nameof(Index));
            }
            return View(leave);
        }

       
       

        private bool LeaveTypeExists(int id)
        {
            return _context.leaveType.Any(e => e.leaveTypeID == id);
        }
    }
}
