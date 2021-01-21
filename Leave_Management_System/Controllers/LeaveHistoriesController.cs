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
    public class LeaveHistoriesController : Controller
    {
        private readonly LeaveDbContext _context;

        public LeaveHistoriesController(LeaveDbContext context)
        {
            _context = context;
        }

        // GET: LeaveHistories
        public async Task<IActionResult> Index()
        {
            var leaveDbContext = _context.LeaveHistory.Include(l => l.dean).Include(l => l.faculty).Include(l => l.hod).Include(l => l.ragistrar);
            return View(await leaveDbContext.ToListAsync());
        }

        // GET: LeaveHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveHistory = await _context.LeaveHistory
                .Include(l => l.dean)
                .Include(l => l.faculty)
                .Include(l => l.hod)
                .Include(l => l.ragistrar)
                .FirstOrDefaultAsync(m => m.leave_id == id);
            if (leaveHistory == null)
            {
                return NotFound();
            }

            return View(leaveHistory);
        }

        // GET: LeaveHistories/Create
        public IActionResult Create()
        {
            ViewData["Dean_id"] = new SelectList(_context.Dean, "Dean_id", "Dean_id");
            ViewData["Faculty_id"] = new SelectList(_context.Faculty, "Faculty_id", "Faculty_id");
            ViewData["HOD_id"] = new SelectList(_context.HOD, "HOD_id", "HOD_id");
            ViewData["Registrar_id"] = new SelectList(_context.Registrar, "Registrar_id", "Registrar_id");
            return View();
        }

        // POST: LeaveHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("leave_id,LeaveStatus,HODApproveStatus,DeanApproveStatus,RegistrarApproveStatus,NoOfDay,LeaveReason,StartFrome,EndTill,Registrar_id,HOD_id,Faculty_id,Dean_id")] LeaveHistory leaveHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaveHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Dean_id"] = new SelectList(_context.Dean, "Dean_id", "Dean_id", leaveHistory.Dean_id);
            ViewData["Faculty_id"] = new SelectList(_context.Faculty, "Faculty_id", "Faculty_id", leaveHistory.Faculty_id);
            ViewData["HOD_id"] = new SelectList(_context.HOD, "HOD_id", "HOD_id", leaveHistory.HOD_id);
            ViewData["Registrar_id"] = new SelectList(_context.Registrar, "Registrar_id", "Registrar_id", leaveHistory.Registrar_id);
            return View(leaveHistory);
        }

        // GET: LeaveHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveHistory = await _context.LeaveHistory.FindAsync(id);
            if (leaveHistory == null)
            {
                return NotFound();
            }
            ViewData["Dean_id"] = new SelectList(_context.Dean, "Dean_id", "Dean_id", leaveHistory.Dean_id);
            ViewData["Faculty_id"] = new SelectList(_context.Faculty, "Faculty_id", "Faculty_id", leaveHistory.Faculty_id);
            ViewData["HOD_id"] = new SelectList(_context.HOD, "HOD_id", "HOD_id", leaveHistory.HOD_id);
            ViewData["Registrar_id"] = new SelectList(_context.Registrar, "Registrar_id", "Registrar_id", leaveHistory.Registrar_id);
            return View(leaveHistory);
        }

        // POST: LeaveHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("leave_id,LeaveStatus,HODApproveStatus,DeanApproveStatus,RegistrarApproveStatus,NoOfDay,LeaveReason,StartFrome,EndTill,Registrar_id,HOD_id,Faculty_id,Dean_id")] LeaveHistory leaveHistory)
        {
            if (id != leaveHistory.leave_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveHistoryExists(leaveHistory.leave_id))
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
            ViewData["Dean_id"] = new SelectList(_context.Dean, "Dean_id", "Dean_id", leaveHistory.Dean_id);
            ViewData["Faculty_id"] = new SelectList(_context.Faculty, "Faculty_id", "Faculty_id", leaveHistory.Faculty_id);
            ViewData["HOD_id"] = new SelectList(_context.HOD, "HOD_id", "HOD_id", leaveHistory.HOD_id);
            ViewData["Registrar_id"] = new SelectList(_context.Registrar, "Registrar_id", "Registrar_id", leaveHistory.Registrar_id);
            return View(leaveHistory);
        }

        // GET: LeaveHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveHistory = await _context.LeaveHistory
                .Include(l => l.dean)
                .Include(l => l.faculty)
                .Include(l => l.hod)
                .Include(l => l.ragistrar)
                .FirstOrDefaultAsync(m => m.leave_id == id);
            if (leaveHistory == null)
            {
                return NotFound();
            }

            return View(leaveHistory);
        }

        // POST: LeaveHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveHistory = await _context.LeaveHistory.FindAsync(id);
            _context.LeaveHistory.Remove(leaveHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveHistoryExists(int id)
        {
            return _context.LeaveHistory.Any(e => e.leave_id == id);
        }
    }
}
