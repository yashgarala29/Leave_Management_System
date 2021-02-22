using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AdminController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        //[HttpGet]
        //public async Task<IActionResult> ListOfAllUser()
        //{
        //    var userlist = userManager.Users.ToList();
        //    var rolelist = roleManager.Roles.ToList();
        //    var user_role_list = new List<UserRoleViewModel>();
        //    for (int i = 0; i < userlist.Count; i++)
        //    {
        //        var usermanager = (await userManager.GetRolesAsync(userlist[i])).FirstOrDefault();
        //        var userRoleViewModel = new UserRoleViewModel
        //        {
        //            UserId = userlist[i].Id,
        //            Email = userlist[i].Email,
        //            //RoleName=rolelist.Where(a=>a.Id==usermanager).FirstOrDefault().Id,
        //            RoleId = usermanager,

        //        };
        //        userRoleViewModel.Role = rolelist;
        //        user_role_list.Add(userRoleViewModel);
        //    }
        //    return View(user_role_list);
        //}
        //[HttpPost]
        //public IActionResult ListOfAllUser()
        //{
        //    return View();
        //}
    }
}
