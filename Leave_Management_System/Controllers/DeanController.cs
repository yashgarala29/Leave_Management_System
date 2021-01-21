using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class DeanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
