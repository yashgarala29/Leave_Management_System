using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class RoleController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ListOfAllUser()
        {
            var userlist = userManager.Users.ToList();
            var rolelist = roleManager.Roles.ToList();
            var user_role_list = new List<UserRoleViewModel>();
            
            for (int i = 0; i < userlist.Count; i++)
            {
                var usermanager = (await userManager.GetRolesAsync(userlist[i])).FirstOrDefault();
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = userlist[i].Id,
                    Email = userlist[i].Email,
                    //RoleName=rolelist.Where(a=>a.Id==usermanager).FirstOrDefault().Id,
                    RoleId = usermanager,

                };
                userRoleViewModel.Role = rolelist;
                user_role_list.Add(userRoleViewModel);
            }
            return View(user_role_list);
        }
        [HttpPost]
        public async Task<IActionResult> ListOfAllUser(int? x)
        {
            string UserId = HttpContext.Request.Query["UserId"];
            string RoleId=HttpContext.Request.Query["RoleId"];
            if(UserId==null || RoleId==null)
            {

                return RedirectToAction("ListOfAllUser", "Role");
            }
            IdentityUser user= await userManager.FindByIdAsync(UserId);
            var new_role = (await roleManager.FindByIdAsync(RoleId)).Name;
            var user_role = (await userManager.GetRolesAsync(user)).FirstOrDefault();
            await userManager.RemoveFromRoleAsync(user,user_role);
            await userManager.AddToRoleAsync(user, new_role);
            //System.Console.WriteLine("svuhfodsifhadhfidfhh");
            //return View();
             return RedirectToAction("ListOfAllUser", "Role");
        }
        //[HttpGet]
        //public IActionResult UserRole()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult UserRole()
        //{
        //    ViewBag.CurrentRole = "Faculty";

        //    var user_model = new List<UserRoleViewModel>();
        //    //SelectList selectListItems=new SelectList()
        //    foreach (var user in userManager.Users)
        //    {
        //        var userviewrolemodel = new UserRoleViewModel
        //        {
        //            Email = user.Email,
        //            UserId = user.Id
        //        };
        //        //IList<string> role= await  userManager.GetRolesAsync(user);
        //        //if(role[0]==null)
        //        //{

        //        //}
        //        user_model.Add(userviewrolemodel);

        //    }
        //    return View(user_model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> UserRole(UserRoleViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("index", "home");
        //        }
        //        foreach (IdentityError error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }
        //    return View(model);
        //}


    }
}
