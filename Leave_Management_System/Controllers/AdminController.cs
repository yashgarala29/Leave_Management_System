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
        public async Task<IActionResult> UpdateLeaveType(int id,leaveType leaveType )
        {
            if (id != leaveType.leaveTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypeExists(leaveType.leaveTypeID))
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
            return View(leaveType);
        }

        // POST: AllUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        //[Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<bool> DeleteConfirmed(int id)
        {
            var allUser = await _context.AllUser.FindAsync(id);
            _context.AllUser.Remove(allUser);
            await _context.SaveChangesAsync();
            return true;
        }

        private bool LeaveTypeExists(int id)
        {
            return _context.leaveType.Any(e => e.leaveTypeID == id);
        }
    }
}
