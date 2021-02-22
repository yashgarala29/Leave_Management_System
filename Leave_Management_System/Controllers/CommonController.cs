using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
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
        public CommonController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        static OwnProfile ownProfile_transfer;
        [HttpGet]
        [Authorize(Roles = "Pending,Dean,Faculty,admin,HOD")]
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
            };
            ownProfile_transfer = ownProfile;
            return View(ownProfile);
        }
        [HttpPost]
        [Authorize(Roles = "Pending,Dean,Faculty,admin,HOD")]
        public async Task<IActionResult> OwnProfile(OwnProfile ownProfile)
        {
            //var userLoginDetail = userManager.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            //var userdetail = _context.AllUser.Where(x => x.Email == userLoginDetail.Email).FirstOrDefault();
            if (ModelState.IsValid)
            {
                AllUser allUser = new AllUser
                {
                    id = ownProfile.id,
                    LastName = ownProfile.LastName,
                    Addreaddress = ownProfile.Addreaddress,
                    Email = User.Identity.Name,
                    City = ownProfile.City,
                    MiddleName = ownProfile.MiddleName,
                    MobileNo = ownProfile.MobileNo.ToString(),
                    MobileNo2 = ownProfile.MobileNo2.ToString(),
                    Name = ownProfile.Name,
                    PaidLeave = ownProfile_transfer.PaidLeave

                };

                try
                {

                    _context.Update(allUser);
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
        //[HttpGet]
        //[Authorize(Roles = "Pending,Dean,Faculty,admin,HOD")]
        //public IActionResult OwnProfile()
        //{
        //    return View();
        //}

    }
}