using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace Leave_Management_System.Controllers
{
    public class AllUsersController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;

        public AllUsersController(LeaveDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.roleManager = roleManager;
        }

        // GET: AllUsers
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.AllUser.ToListAsync());
        }

        // GET: AllUsers/Details/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allUser = await _context.AllUser
                .FirstOrDefaultAsync(m => m.id == id);
            if (allUser == null)
            {
                return NotFound();
            }

            return View(allUser);
        }

        // GET: AllUsers/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: AllUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Create([Bind("id,Email,MobileNo,MobileNo2,Name,LastName,MiddleName,Deparment,Role,Addreaddress,City,PaidLeave")] AllUser allUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allUser);
        }


        // GET: AllUsers/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allUser = await _context.AllUser.FindAsync(id);
            if (allUser == null)
            {
                return NotFound();
            }
            return View(allUser);
        }

        // POST: AllUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int id, [Bind("id,Email,MobileNo,MobileNo2,Name,LastName,MiddleName,Deparment,Role,Addreaddress,City,PaidLeave")] AllUser allUser)
        {
            if (id != allUser.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllUserExists(allUser.id))
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
            return View(allUser);
        }

        // GET: AllUsers/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allUser = await _context.AllUser
                .FirstOrDefaultAsync(m => m.id == id);
            if (allUser == null)
            {
                return NotFound();
            }

            return View(allUser);
        }

        // POST: AllUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allUser = await _context.AllUser.FindAsync(id);
            _context.AllUser.Remove(allUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllUserExists(int id)
        {
            return _context.AllUser.Any(e => e.id == id);
        }
    }
}
