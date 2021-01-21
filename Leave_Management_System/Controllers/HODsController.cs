using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Leave_Management_System.Models;
using Leave_Management_System.Models.Context;

namespace Leave_Management_System.Controllers
{
    public class HODsController : Controller
    {
        private readonly LeaveDbContext _context;

        public HODsController(LeaveDbContext context)
        {
            _context = context;
        }

        // GET: HODs
        public async Task<IActionResult> Index()
        {
            return View(await _context.HOD.ToListAsync());
        }

        // GET: HODs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOD = await _context.HOD
                .FirstOrDefaultAsync(m => m.HOD_id == id);
            if (hOD == null)
            {
                return NotFound();
            }

            return View(hOD);
        }

        // GET: HODs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HODs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HOD_id,MobileNo,FirstName,LastName,Deparment,FreeLeave")] HOD hOD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hOD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hOD);
        }

        // GET: HODs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOD = await _context.HOD.FindAsync(id);
            if (hOD == null)
            {
                return NotFound();
            }
            return View(hOD);
        }

        // POST: HODs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HOD_id,MobileNo,FirstName,LastName,Deparment,FreeLeave")] HOD hOD)
        {
            if (id != hOD.HOD_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hOD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HODExists(hOD.HOD_id))
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
            return View(hOD);
        }

        // GET: HODs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOD = await _context.HOD
                .FirstOrDefaultAsync(m => m.HOD_id == id);
            if (hOD == null)
            {
                return NotFound();
            }

            return View(hOD);
        }

        // POST: HODs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hOD = await _context.HOD.FindAsync(id);
            _context.HOD.Remove(hOD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HODExists(int id)
        {
            return _context.HOD.Any(e => e.HOD_id == id);
        }
    }
}
