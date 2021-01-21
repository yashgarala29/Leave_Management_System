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
    public class FacultyController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public FacultyController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult LeaveRequest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LeaveRequest(LeaveRequest leaveRequest)
        {
            string username = User.Identity.Name;
            var singleUser = _context.AllUser.Where(x => x.Email == username).FirstOrDefault();
            var leaveHistory = new LeaveHistory
            {
                StartFrome = leaveRequest.LeaveStartFrome,
                EndTill = leaveRequest.LeaveEndTill,
                LeaveReason = leaveRequest.LeaveReason,
                NoOfDay = (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays),
                DeanApproveStatus = "Pending",
                HODApproveStatus= "Pending",
                RegistrarApproveStatus= "Pending",
                LeaveStatus= "Pending",
                id = singleUser.id,
            };
            _context.LeaveHistory.Add(leaveHistory);
            _context.SaveChangesAsync();
            return View();
        }
    }
}
