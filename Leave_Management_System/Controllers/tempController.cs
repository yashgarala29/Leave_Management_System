using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Leave_Management_System.Controllers
{
    public class tempController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public tempController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        [Authorize(Roles = "Pending")]
        public IActionResult pendingView()
        {
            return View();
        }
        /*
        [Authorize(Roles = "Dean")]
        public IActionResult DeanView()
        {
            return View();
        }
        [Authorize(Roles = "Faculty")]
        public IActionResult Facultyview()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        public IActionResult AdminView()
        {
            return View();
        }
        [Authorize(Roles = "HOD")]
        public IActionResult HODview()
        {
            return View();
        }
        [Authorize(Roles = "Registrar")]
        public IActionResult RegistrarView()
        {
            
            return View();
        }
        */
    }
}
