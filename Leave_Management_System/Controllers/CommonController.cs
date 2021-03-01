using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Leave_Management_System.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class CommonController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmailService emailService;

        public CommonController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IEmailService emailService)
        {
            _context = context;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.emailService = emailService;
            this.userManager = userManager;
        }

        static OwnProfile ownProfile_transfer;
        [HttpGet]
        [Authorize(Roles = "Pending,Dean,Faculty,admin,HOD,Registrar")]
        public IActionResult OwnProfile()
        {
            var userLoginDetail = userManager.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            var userdetail = _context.AllUser.Where(x => x.Email == userLoginDetail.Email).FirstOrDefault();

            OwnProfile ownProfile = new OwnProfile
            {
                id = userdetail.id,
                LastName = userdetail.LastName,
                Addreaddress = userdetail.Addreaddress,
                Email = userdetail.Email,
                City = userdetail.City,
                MiddleName = userdetail.MiddleName,
                MobileNo =userdetail.MobileNo,
                MobileNo2 = userdetail.MobileNo2,
                Name = userdetail.Name,
                PaidLeave = userdetail.PaidLeave,
                Department=userdetail.Deparment,
                Role=userdetail.Role
            };
            ownProfile_transfer = ownProfile;
            return View(ownProfile);
        }
        [HttpPost]
        [Authorize(Roles = "Pending,Dean,Faculty,admin,HOD,Registrar")]
        public async Task<IActionResult> OwnProfile(OwnProfile ownProfile)
        {
            //var userLoginDetail = userManager.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            var userdetail = await _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefaultAsync();
            if (ModelState.IsValid)
            {
                    userdetail.LastName = ownProfile.LastName;
                userdetail.Addreaddress = ownProfile.Addreaddress;
                userdetail.City = ownProfile.City;
                userdetail.MiddleName = ownProfile.MiddleName;
                userdetail.MobileNo = ownProfile.MobileNo.ToString();
                userdetail.MobileNo2 = (ownProfile.MobileNo2 == null) ? 0.ToString() : ownProfile.MobileNo2.ToString();
                userdetail.Name = ownProfile.Name;
                    
                try
                {

                    _context.AllUser.Update(userdetail);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(controllerName: "common", actionName: "OwnProfile");
                }
                catch (DbUpdateConcurrencyException)
                {

                    return View(ownProfile);

                }
            }

            return View(ownProfile);
        }
        [HttpGet]
        [Authorize(Roles = "Dean,admin,HOD,Registrar")]
        public async Task<IActionResult> ListLeaveAllocation()
        {
            var loginuser = User.Identity.Name;
            var curentuser = await _context.AllUser.Where(x => x.Email == loginuser).FirstOrDefaultAsync();
            List<LeaveAllocation> listof;
            if(curentuser.Role=="HOD"  )
            {
                 listof =await _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType)
                    .Where(y => y.AllUser.Role == "Faculty" && y.AllUser.Deparment== curentuser.Deparment).ToListAsync();
                
            }
            else if (curentuser.Role == "Dean")
            {
                 listof =await _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType)
                    .Where(y => y.AllUser.Role == "HOD" ).ToListAsync();

            }
            else if (curentuser.Role == "Registrar")
            {
                 listof =await _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType)
                                    .Where(y => y.AllUser.Role == "Dean" ).ToListAsync();

            }
            else
            {
                listof = new List<LeaveAllocation>();
            }
            return View(listof);
        }
        
        }
}