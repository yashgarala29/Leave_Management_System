using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
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
        private readonly LeaveDbContext _context;
        public RoleController(LeaveDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
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
                foreach (IdentityError error in result.Errors)
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
            var department_list = new List<string>();
                

            for (int i = 0; i < userlist.Count; i++)
            {
                var usermanager = (await userManager.GetRolesAsync(userlist[i])).FirstOrDefault();
                string UserId = userlist[i].Id;
                string Email = userlist[i].Email;
                //RoleName=rolelist.Where(a=>a.Id==usermanager).FirstOrDefault().Id,
                
                
                string aa= userlist[i].UserName;

            string RoleId = usermanager;
               var  CurentDepartment = ( _context.AllUser.Where(x => x.Email == aa)).FirstOrDefault();

                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = userlist[i].Id,
                    Email = userlist[i].Email,
                    //RoleName=rolelist.Where(a=>a.Id==usermanager).FirstOrDefault().Id,
                    RoleId = usermanager,
                    CurentDepartment = _context.AllUser.Where(x => x.Email == userlist[i].Email).FirstOrDefault().Deparment

                };
                userRoleViewModel.Department = Enum.GetNames(typeof(Department)).ToList();
                userRoleViewModel.Role = rolelist;

                user_role_list.Add(userRoleViewModel);
            }
            return View(user_role_list);
        }
        [HttpPost]
        public async Task<IActionResult> ListOfAllUser(int? x)
        {
            try
            {
                string UserId = HttpContext.Request.Query["UserId"];
                string RoleId = HttpContext.Request.Query["RoleId"];
                string deparment_name = HttpContext.Request.Query["Deparment"];
                if (RoleId == null && deparment_name == null)
                {

                    return RedirectToAction("ListOfAllUser", "Role");
                }
                IdentityUser user = await userManager.FindByIdAsync(UserId); ;
                if (RoleId != null)
                {

                    var new_role = (await roleManager.FindByIdAsync(RoleId)).Name;

                    var user_role = (await userManager.GetRolesAsync(user)).FirstOrDefault();
                    var user_change = _context.AllUser.Where(x => x.Email == user.Email).FirstOrDefault();
                    user_change.Role = new_role;
                    _context.AllUser.Update(user_change);
                    await _context.SaveChangesAsync();

                    await userManager.RemoveFromRoleAsync(user, user_role);
                    await userManager.AddToRoleAsync(user, new_role);
                }
                if (deparment_name != null)
                {
                    var user_change = _context.AllUser.Where(x => x.Email == user.Email).FirstOrDefault();
                    user_change.Deparment = deparment_name;
                    _context.AllUser.Update(user_change);
                    await _context.SaveChangesAsync();
                }
                //System.Console.WriteLine("svuhfodsifhadhfidfhh");
                //return View();
            }
            catch (Exception)
            {

            }
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
