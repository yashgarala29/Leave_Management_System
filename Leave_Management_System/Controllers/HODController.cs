﻿
using Leave_Management_System.Models.Class;
using Leave_Management_System.Models.Context;
using Leave_Management_System.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
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
        private readonly RoleManager<IdentityRole> roleManager;
        public HODController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        [Authorize(Roles = "HOD")]
        public IActionResult LeaveRequest()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "HOD")]
        public async Task<IActionResult> ListLeaveAllocation()
        {
            
            //string curentUser = User.Identity.Name;
            //var LeaveTypeName = _context.LeaveHistory.Include(x => x.leaveType.LeaveType).Where(x => x.AllUser.Role == "Faculty");
            //var userlevelist = _context.leaveAllocation.Include(x => x.leaveType).Where(x => x.AllUser.Email == curentUser);
            var leaveDbContext = _context.leaveAllocation.Include(l => l.AllUser).Include(x => x.leaveType).Where(y => y.AllUser.Role == "Faculty");
            return View(await leaveDbContext.ToListAsync());
        }

        [Authorize(Roles = "HOD")]
        public IActionResult HomePageHOD()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "HOD")]
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
                HODApproveStatus = "Pending",
                RegistrarApproveStatus = "Pending",
                LeaveStatus = "Pending",
                id = singleUser.id,
            };
            _context.LeaveHistory.Add(leaveHistory);
            _context.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "HOD")]
        public IActionResult MyLeave()
        {
            string curentUser = User.Identity.Name;
            var userlevelist = _context.LeaveHistory.Where(x => x.AllUser.Email == curentUser).ToList();
            List<MyLeave> myLeaves = new List<MyLeave>();
            foreach (var temp in userlevelist)
            {
                int status = DateTime.Compare(temp.StartFrome, DateTime.Now);
                var singleLeave = new MyLeave
                {
                    EndTill = temp.EndTill,
                    LeaveReason = temp.LeaveReason,
                    LeaveStatus = temp.LeaveStatus,
                    leave_id = temp.leave_id,
                    NoOfDay = temp.NoOfDay,
                    StartFrome = temp.StartFrome,
                    changeable = (status > 0) ? 1 : 0,
                };
                myLeaves.Add(singleLeave);
            }
            return View(myLeaves);
        }

        


        [HttpGet]
        [Authorize(Roles = "HOD")]
        public async Task<IActionResult> ListOfLeaveRequest()
        {
            var hodDeparment = _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            List<LeaveHistory> leaveHistories = new List<LeaveHistory>();
            var t = await userManager.GetUsersInRoleAsync("Faculty");
            var HODDeparment = _context.AllUser.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Deparment;
            foreach (var temp in t)
            {
                var requestedleave = _context.LeaveHistory.Include(l => l.AllUser)
                .Where(x => (x.AllUser.Email == temp.Email && x.AllUser.Deparment == HODDeparment && x.HODApproveStatus == "Pending")).FirstOrDefault();
                if (requestedleave != null)
                    leaveHistories.Add(requestedleave);
            }

            var allrequest = new List<ListOfLeaveRequestHOD>();
            for (int i = 0; i < leaveHistories.Count; i++)
            {
                var listre = new ListOfLeaveRequestHOD
                {
                    id = leaveHistories[i].leave_id,
                    FirstName = leaveHistories[i].AllUser.Name,
                    LastName = leaveHistories[i].AllUser.LastName,
                    LeaveEndTill = leaveHistories[i].EndTill,
                    LeaveReason = leaveHistories[i].LeaveReason,
                    LeaveStartFrome = leaveHistories[i].StartFrome,
                    NoOfDay = leaveHistories[i].NoOfDay,
                    username = leaveHistories[i].AllUser.Email,
                    Status = Enum.GetNames(typeof(Status)).ToList()
                };
                allrequest.Add(listre);
            }
            return View(allrequest);
        }

        [HttpPost]
        [Authorize(Roles = "HOD")]
        public async Task<JsonResult> AjaxMethod(string name, string leave_id)
        {
            int leave_id_int = int.Parse(leave_id);
            var leave = _context.LeaveHistory.Where(x => x.leave_id == leave_id_int).FirstOrDefault();
            leave.HODApproveStatus = name;
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
            return Json(leave);
        }

    }
}