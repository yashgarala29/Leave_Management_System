using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Leave_Management_System.Models.Context;
using Microsoft.EntityFrameworkCore;
using Leave_Management_System.Models.ViewModel;
using Leave_Management_System.Models.Class;

namespace Leave_Management_System.Controllers
{
    public class tempController : Controller
    {
        private readonly LeaveDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public tempController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        [Authorize(Roles = "Pending")]
        public IActionResult pendingView()
        {
            return View();
        }
        [Authorize]
        public IActionResult Notification()
        {
            //var user_id = User.Identity.Name;
            //var arr =  context.Notifications.Include(l => l.AllUser).Where(x => x.AllUser.Email == user_id).OrderBy(x=>x.isreaded).ToList();
            
            return View();
        }
        [HttpPost]
        public List<Notification> GetNotification()
        {
            var user_id = User.Identity.Name;
            var arr = context.Notifications.Include(l => l.AllUser).Where(x => x.AllUser.Email == user_id).OrderBy(x => x.isreaded).ToList();

            return arr;
        }
    }
}
