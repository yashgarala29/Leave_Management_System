using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Leave_Management_System.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly IEmailService emailService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(LeaveDbContext context, IEmailService emailService, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.emailService = emailService;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            // If password reset token or email is null, most likely the
            // user tried to tamper the password reset link
            if (token == null || email == null)
            {
                ModelState.AddModelError("", "Invalid password reset token");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(resetPassword model)
        {
            if (ModelState.IsValid)
            {
                // Find the user by email
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    // reset the user password
                    var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        ViewBag.sucess = "Your Password is change";
                        return RedirectToAction("Login");
                    }
                    // Display validation errors. For example, password reset token already
                    // used to change the password or password complexity rules not met
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

                // To avoid account enumeration and brute force attacks, don't
                // reveal that the user does not exist
                return RedirectToAction("Register");
            }
            // Display validation errors if model state is not valid
            return View(model);
        }

        [HttpGet]
        public IActionResult forgotpassword()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> forgotpassword(forgotpasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordresetlink = Url.Action("resetPassword", "Account",
                         new { email = model.Email, token = token }, Request.Scheme);

                    UserEmail userEmail = new UserEmail
                    {
                        ToEmail = model.Email,

                    };
                    var arr = new List<KeyValuePair<string, string>>();
                    var temp = new KeyValuePair<string, string>("{{passwordlink}}", passwordresetlink);

                    //temp.Key = "username";
                    //temp.Value = "yashgarala29@gmail.com";
                    arr.Add(temp);
                    userEmail.PlaceHolder = arr;
                    await emailService.ForgotpasswordEmail(userEmail);
                    ViewBag.msg = "We send Password reset link To your account";
                    return View();
                }
                ModelState.AddModelError(string.Empty, "Your Account is not found");
                return View();
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (signInManager.IsSignedIn(User))
            {
                var x = (await signInManager.UserManager.GetRolesAsync(await signInManager.UserManager.FindByNameAsync(User.Identity.Name)));

                string role_user = x[0];
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
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, true, false);

                if (result.Succeeded)
                {
                    var curent_user = await userManager.FindByEmailAsync(model.Email);
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
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email

                };
                var result = await userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    AllUser allUser = new AllUser();
                    allUser.Role = "Pending";
                    allUser.Email = registerViewModel.Email;
                    allUser.PaidLeave = 20;
                    allUser.Deparment = "Pending";
                    _context.Add(allUser);
                    await _context.SaveChangesAsync();
                    var s = userManager.Users.Where(a => a.Email == registerViewModel.Email).FirstOrDefault();
                    IdentityResult identityResult = await userManager.AddToRoleAsync(s, "Pending");
                    //IdentityResult identityResult = await userManager.AddToRoleAsync(s, "Admin");
                    await leaveallocationToALL(s.Email);
                    if (identityResult.Succeeded)
                        return RedirectToAction("index", "home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(registerViewModel);
        }

        public async Task<bool> leaveallocationToALL(string  email)
        {
            var alluser_list = await _context.AllUser.FirstOrDefaultAsync(x=>x.Email==email);
            var leavetype = await _context.leaveType.ToListAsync();
            if (alluser_list == null)
            {
                return false;
            }
            try
            {
                for (int i = 0; i < leavetype.Count; i++)
                {
                    var leavealocation = new LeaveAllocation
                    {
                        id = alluser_list.id,
                        NoOfLeave = leavetype[i].noofday,
                        leaveTypeID = leavetype[i].leaveTypeID,

                    };
                    _context.leaveAllocation.Add(leavealocation);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");

        }





    }
}
