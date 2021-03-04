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
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AllUsersController(LeaveDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        // GET: AllUsers
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Index(
    string sortOrder,
    string currentFilter,
    string searchString,
    int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;

            ViewData["EmailSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Email_desc" : "";
            ViewData["MobileNoSortParm"] = String.IsNullOrEmpty(sortOrder) ? "MobileNo_desc" : "";
            ViewData["MobileNo2SortParm"] = String.IsNullOrEmpty(sortOrder) ? "MobileNo2_desc" : "";
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewData["LastNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "LastName_desc" : "";
            ViewData["MiddleNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "MiddleName_desc" : "";
            ViewData["DeparmentSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Department_desc" : "";
            ViewData["RoleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Role_desc" : "";
            ViewData["AddreaddressSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Addreaddress_desc" : "";
            ViewData["CitySortParm"] = String.IsNullOrEmpty(sortOrder) ? "City_desc" : "";
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

           

            var allusers = from s in _context.AllUser select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                allusers = allusers.Where(s => s.Email.Contains(searchString)
                || s.MobileNo.Contains(searchString)
                || s.MobileNo2.Contains(searchString)
                || s.Name.Contains(searchString)
                || s.LastName.Contains(searchString)
                || s.MiddleName.Contains(searchString)
                || s.Deparment.Contains(searchString)
                || s.Role.Contains(searchString)
                || s.Addreaddress.Contains(searchString)
                || s.City.Contains(searchString)
                
                );
            }

           


            switch (sortOrder)
            {
                case "Email_desc":
                    allusers = allusers.OrderByDescending(s => s.Email);
                    break;

                case "MobileNo_desc":
                    allusers = allusers.OrderByDescending(s => s.MobileNo);
                    break;

                case "MobileNo2_desc":
                    allusers = allusers.OrderByDescending(s => s.MobileNo2);
                    break;

                case "Name_desc":
                    allusers = allusers.OrderByDescending(s => s.Name);
                    break;

                case "LastName_desc":
                    allusers = allusers.OrderByDescending(s => s.LastName);
                    break;

                case "MiddleName_desc":
                    allusers = allusers.OrderByDescending(s => s.MiddleName);
                    break;

                case "Department_desc":
                    allusers = allusers.OrderByDescending(s => s.Deparment);
                    break;

                case "Role_desc":
                    allusers = allusers.OrderByDescending(s => s.Role);
                    break;
                case "Addreaddress_desc":
                    allusers = allusers.OrderByDescending(s => s.Addreaddress);
                    break;
                case "City_desc":
                    allusers = allusers.OrderByDescending(s => s.City);
                    break;
                default:
                    allusers = allusers.OrderBy(s => s.City);
                    break;
            }
            //return View(await allusers.AsNoTracking().ToListAsync());
            int pageSize = 5;
            return View(await PaginatedList<AllUser>.CreateAsync(allusers.AsNoTracking(), pageNumber ?? 1, pageSize));
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
        public async Task<IActionResult> DeleteConfirmed(int id,string email)
        {
            var allUser = await _context.AllUser.FindAsync(id);
            _context.AllUser.Remove(allUser);
            await _context.SaveChangesAsync();


            var user = await userManager.FindByEmailAsync(email);
            IdentityResult result = await userManager.DeleteAsync(user);


            return RedirectToAction(nameof(Index));





        }

        private bool AllUserExists(int id)
        {
            return _context.AllUser.Any(e => e.id == id);
        }
    }
}
