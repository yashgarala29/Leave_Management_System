using Leave_Management_System.Models;
using Leave_Management_System.Models.ViewModel;
using Leave_Management_System.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService emailService;

        public HomeController(ILogger<HomeController> logger, IEmailService emailService)
        {
            this.emailService = emailService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            UserEmail userEmail = new UserEmail
            {
                ToEmail = "brijesh.chudasama2012@gmail.com",


            };
            var arr = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>("{{username}}", "brijesh.chudasama2012@gmail.com");
            //temp.Key = "username";
            //temp.Value = "yashgarala29@gmail.com";
            arr.Add(temp);
            userEmail.PlaceHolder = arr;
            await emailService.SendTestEmail(userEmail);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
