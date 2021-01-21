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
    public class RegistrarsController : Controller
    {
        private readonly LeaveDbContext _context;

        public RegistrarsController(LeaveDbContext context)
        {
            _context = context;
        }

        // GET: Registrars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registrar.ToListAsync());
        }

        // GET: Registrars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrar = await _context.Registrar
                .FirstOrDefaultAsync(m => m.Registrar_id == id);
            if (registrar == null)
            {
                return NotFound();
            }

            return View(registrar);
        }

        // GET: Registrars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registrars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Registrar_id,MobileNo,FirstName,LastName,Deparment,FreeLeave")] Registrar registrar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registrar);
        }

        // GET: Registrars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrar = await _context.Registrar.FindAsync(id);
            if (registrar == null)
            {
                return NotFound();
            }
            return View(registrar);
        }

        // POST: Registrars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Registrar_id,MobileNo,FirstName,LastName,Deparment,FreeLeave")] Registrar registrar)
        {
            if (id != registrar.Registrar_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrarExists(registrar.Registrar_id))
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
            return View(registrar);
        }

        // GET: Registrars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrar = await _context.Registrar
                .FirstOrDefaultAsync(m => m.Registrar_id == id);
            if (registrar == null)
            {
                return NotFound();
            }

            return View(registrar);
        }

        // POST: Registrars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrar = await _context.Registrar.FindAsync(id);
            _context.Registrar.Remove(registrar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrarExists(int id)
        {
            return _context.Registrar.Any(e => e.Registrar_id == id);
        }
    }
}
