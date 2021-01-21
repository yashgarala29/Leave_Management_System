using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;

namespace Leave_Management_System.Controllers
{
    public class DeansController : Controller
    {
        private readonly LeaveDbContext _context;

        public DeansController(LeaveDbContext context)
        {
            _context = context;
        }

        // GET: Deans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dean.ToListAsync());
        }

        // GET: Deans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dean = await _context.Dean
                .FirstOrDefaultAsync(m => m.Dean_id == id);
            if (dean == null)
            {
                return NotFound();
            }

            return View(dean);
        }

        // GET: Deans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Deans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Dean_id,MobileNo,FirstName,LastName,Deparment,FreeLeave")] Dean dean)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dean);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dean);
        }

        // GET: Deans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dean = await _context.Dean.FindAsync(id);
            if (dean == null)
            {
                return NotFound();
            }
            return View(dean);
        }

        // POST: Deans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Dean_id,MobileNo,FirstName,LastName,Deparment,FreeLeave")] Dean dean)
        {
            if (id != dean.Dean_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dean);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeanExists(dean.Dean_id))
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
            return View(dean);
        }

        // GET: Deans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dean = await _context.Dean
                .FirstOrDefaultAsync(m => m.Dean_id == id);
            if (dean == null)
            {
                return NotFound();
            }

            return View(dean);
        }

        // POST: Deans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dean = await _context.Dean.FindAsync(id);
            _context.Dean.Remove(dean);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeanExists(int id)
        {
            return _context.Dean.Any(e => e.Dean_id == id);
        }
    }
}
