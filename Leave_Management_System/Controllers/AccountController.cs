using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AccountController(LeaveDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager
            , IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.signInManager = signInManager;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
        }
        static List<string> errorList = new List<string>();
        [HttpGet]
        public IActionResult Login()
        {
            if(errorList.Count!=0)
            {
                foreach(var temp in errorList)
                {
                    ModelState.AddModelError(string.Empty, temp);
                }
                errorList.Clear();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(CombineLoginRegister model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.LoginCombine.Email, model.LoginCombine.Password, true, false);

                if (result.Succeeded)
                {
                    var curent_user = await userManager.FindByEmailAsync(model.LoginCombine.Email);
                    string role_user = (await userManager.GetRolesAsync(curent_user)).FirstOrDefault();

                    if (role_user == "HOD")
                    {
                        return RedirectToAction("HomePageHOD", "HOD");
                    }
                    else if (role_user == "admin")
                    {
                        return RedirectToAction("Index", "AllUsers");
                    }
                    else if (role_user == "Dean")
                    {
                        return RedirectToAction("HomePageDean", "Dean");
                    }
                    else if (role_user == "Faculty")
                    {
                        return RedirectToAction("HomePageFaculty", "Faculty");
                    }
                    else if (role_user == "Registrar")
                    {
                        return RedirectToAction("HomePageRegistrar", "Registrar");
                    }
                    else if (role_user == "Pending")
                    {
                        return RedirectToAction("pendingView", "temp");
                    }
                    return RedirectToAction("index", "home");
                }
                //ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                errorList.Add("Invalid Login Attempt");
            }
            return View(model);
        }

        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}


        [HttpPost]
        public async Task<IActionResult> Register(CombineLoginRegister registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    Email = registerViewModel.RegisterCombine.Email,
                    UserName = registerViewModel.RegisterCombine.Email

                };
                var result = await userManager.CreateAsync(user, registerViewModel.RegisterCombine.Password);
                if (result.Succeeded)
                {
                    AllUser allUser = new AllUser();
                    allUser.Role = "Pending";
                    allUser.Email = registerViewModel.RegisterCombine.Email;
                    allUser.PaidLeave = 20;
                    allUser.Deparment = "Pending";
                    _context.Add(allUser);
                    await _context.SaveChangesAsync();
                    var s = userManager.Users.Where(a => a.Email == registerViewModel.RegisterCombine.Email).FirstOrDefault();
                    IdentityResult identityResult = await userManager.AddToRoleAsync(s, "Pending");
                    //IdentityResult identityResult = await userManager.AddToRoleAsync(s, "Admin");
                  

                    if (identityResult.Succeeded)
                        return RedirectToAction("index", "home");
                }
                foreach(var error in result.Errors)
                {
                    //ModelState.AddModelError(string.Empty, error.Description);
                    errorList.Add(error.Description);
                }
            }
            
            return RedirectToActionPermanent("Login", "Account", registerViewModel);
             //View(registerViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "home");

        }





    }
}
