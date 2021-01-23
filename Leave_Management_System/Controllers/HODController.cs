using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class HODController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public HODController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> ListOfLeaveRequest()
        {
            var hodDeparment =  _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            var requestedleave =  _context.LeaveHistory.Include(l => l.AllUser)
                .Where(x => (x.AllUser.Deparment==hodDeparment.Deparment && x.AllUser.id!=hodDeparment.id))
                .ToList();
            var allrequest = new List<ListOfLeaveRequestHOD>();
            for(int i=0;i<requestedleave.Count;i++)
            {
                var listre = new ListOfLeaveRequestHOD
                {
                    id = requestedleave[i].leave_id,
                    FirstName = requestedleave[i].AllUser.Name,
                    LastName = requestedleave[i].AllUser.LastName,
                    LeaveEndTill = requestedleave[i].EndTill,
                    LeaveReason = requestedleave[i].LeaveReason,
                    LeaveStartFrome = requestedleave[i].StartFrome,
                    NoOfDay = requestedleave[i].NoOfDay,
                    username = requestedleave[i].AllUser.Email,
                    HODStatus = Enum.GetNames(typeof(Status)).ToList()
                };
                allrequest.Add(listre);
            }
            return View(allrequest);
        }
        [HttpPost]
        public async Task<JsonResult> AjaxMethod(string name,string leave_id)
        {
            int leave_id_int = int.Parse(leave_id);
            var leave=_context.LeaveHistory.Where(x => x.leave_id == leave_id_int).FirstOrDefault();
            leave.LeaveStatus = name;
            
            //try
            //{
                _context.Update(leave);
                await _context.SaveChangesAsync();
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}
            return Json(leave) ;
        }
    }
}
