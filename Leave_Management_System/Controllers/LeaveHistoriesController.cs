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
        public async Task<IActionResult> Index(string sortOrder,
        string currentFilter,
        string searchString,
        int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["EmailSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Email_desc" : "";
            ViewData["LeaveStatusSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LeaveStatus_desc" : "";
            ViewData["HODApproveStatusSortParm"] = String.IsNullOrEmpty(sortOrder) ? "HODApproveStatus_desc" : "";
            ViewData["DeanApproveStatusSortParm"] = String.IsNullOrEmpty(sortOrder) ? "DeanApproveStatus_desc" : "";
            ViewData["RegistrarApproveStatusSortParm"] = String.IsNullOrEmpty(sortOrder) ? "RegistrarApproveStatus_desc" : "";
            ViewData["NoOfDaySortParm"] = String.IsNullOrEmpty(sortOrder) ? "NoOfDay_desc" : "";
            ViewData["LeaveReasonSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LeaveReason_desc" : "";
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



            var allusers = from s in _context.LeaveHistory.Include(s => s.AllUser) select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                allusers = allusers.Where(s => s.AllUser.Email.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Email_desc":
                    allusers = allusers.OrderByDescending(s => s.AllUser.Email);
                    break;

                case "LeaveStatus_desc":
                    allusers = allusers.OrderByDescending(s => s.LeaveStatus);
                    break;

                case "HODApproveStatus_desc":
                    allusers = allusers.OrderByDescending(s => s.HODApproveStatus);
                    break;

                case "DeanApproveStatus_desc":
                    allusers = allusers.OrderByDescending(s => s.DeanApproveStatus);
                    break;

                case "RegistrarApproveStatus_desc":
                    allusers = allusers.OrderByDescending(s => s.RegistrarApproveStatus);
                    break;

                case "NoOfDay_desc":
                    allusers = allusers.OrderByDescending(s => s.NoOfDay);
                    break;

                case "LeaveReason_desc":
                    allusers = allusers.OrderByDescending(s => s.LeaveReason);
                    break;

                case "StartFrome_desc":
                    allusers = allusers.OrderByDescending(s => s.StartFrome);
                    break;
                case "EndTill_desc":
                    allusers = allusers.OrderByDescending(s => s.EndTill);
                    break;
                
                default:
                    allusers = allusers.OrderBy(s => s.AllUser.Email);
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

        // GET: LeaveHistories/Create
        public IActionResult Create()
        {
            ViewData["id"] = new SelectList(_context.AllUser, "id", "id");
            return View();
        }

        // POST: LeaveHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("leave_id,LeaveStatus,HODApproveStatus,DeanApproveStatus,RegistrarApproveStatus,NoOfDay,LeaveReason,StartFrome,EndTill,id")] LeaveHistory leaveHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaveHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["id"] = new SelectList(_context.AllUser, "id", "id", leaveHistory.id);
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
            ViewData["id"] = new SelectList(_context.AllUser, "id", "id", leaveHistory.id);
            return View(leaveHistory);
        }

        // POST: LeaveHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("leave_id,LeaveStatus,HODApproveStatus,DeanApproveStatus,RegistrarApproveStatus,NoOfDay,LeaveReason,StartFrome,EndTill,id")] LeaveHistory leaveHistory)
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
            ViewData["id"] = new SelectList(_context.AllUser, "id", "id", leaveHistory.id);
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
                .Include(l => l.AllUser)
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
