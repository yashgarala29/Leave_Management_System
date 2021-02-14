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
using Leave_Management_System.Service;

namespace Leave_Management_System.Controllers
{
    public class HODController : Controller
    {
        private readonly LeaveDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IEmailService emailService;
        private readonly RoleManager<IdentityRole> roleManager;
        public HODController(LeaveDbContext context, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager,
            IEmailService emailService)
        {
            _context = context;
            this.signInManager = signInManager;
            this.emailService = emailService;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        [Authorize(Roles = "HOD")]
        public IActionResult LeaveRequest()
        {
            return View();
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
            if(ModelState.IsValid)
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
                return RedirectToAction("MyLeave", "HOD");
            }
            return View(leaveRequest);
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
                .Where(x => (x.AllUser.Email == temp.Email && x.AllUser.Deparment == HODDeparment && x.HODApproveStatus == "Pending")).ToList();
                if (requestedleave != null)
                    foreach (var single in requestedleave)
                        leaveHistories.Add(single);

                //leaveHistories.Add(requestedleave);
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

        //---------------
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
        public IActionResult UpdateLeave(int leave_id)
        {
            if (leave_id == 0)
                return NotFound();
            var leaveHistory = _context.LeaveHistory.Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            //
            if (leaveHistory == null)
            {
                //return RedirectToAction("MyLeave", "HOD");

                return NotFound();
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "HOD");
            }
            var leareqyest = new LeaveRequest
            {
                id = leaveHistory.leave_id,
                LeaveEndTill = leaveHistory.EndTill,
                LeaveReason = leaveHistory.LeaveReason,
                LeaveStartFrome = leaveHistory.StartFrome
            };
            //ViewBag.leave = leave_id;
            return View(leareqyest);

        }

        [HttpPost]
        [Authorize(Roles = "HOD")]
        public async Task<IActionResult> UpdateLeave(int id, LeaveRequest leaveRequest)
        {
            int leave_id = id;
            if (leave_id == 0)
                return NotFound();
            var leaveHistory = _context.LeaveHistory.Include(l => l.AllUser)
                .Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            if (leaveHistory == null)
            {
                return NotFound();
                //return RedirectToAction("MyLeave", "HOD");
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "HOD");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    leaveHistory.LeaveReason = leaveRequest.LeaveReason;
                    leaveHistory.LeaveStatus = "Pending";
                    leaveHistory.DeanApproveStatus = "Pending";
                    leaveHistory.EndTill = leaveRequest.LeaveEndTill;
                    leaveHistory.StartFrome = leaveRequest.LeaveStartFrome;
                    leaveHistory.NoOfDay = (int)((leaveRequest.LeaveEndTill - leaveRequest.LeaveStartFrome).TotalDays);
                    var DeanUser = _context.AllUser.Where(x => x.Role == "Dean" ).FirstOrDefault();

                    _context.Update(leaveHistory);
                    await _context.SaveChangesAsync();

                    UserEmail userEmail = new UserEmail
                    {
                        ToEmail = DeanUser.Email,

                    };
                    var arr = new List<KeyValuePair<string, string>>();
                    var temp = new KeyValuePair<string, string>("{{username}}", leaveHistory.AllUser.Email);
                    var StaringDate = new KeyValuePair<string, string>("{{startfrome}}", leaveRequest.LeaveStartFrome.ToLongDateString());
                    var TillDate = new KeyValuePair<string, string>("{{endtill}}", leaveRequest.LeaveEndTill.ToLongDateString());

                    //temp.Key = "username";
                    //temp.Value = "yashgarala29@gmail.com";
                    arr.Add(temp);
                    arr.Add(StaringDate);
                    arr.Add(TillDate);
                    userEmail.PlaceHolder = arr;
                    await emailService.SendLeaveUpdateEmail(userEmail);

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction("MyLeave", "HOD");
            };
            return View(leaveRequest);
        }


        [HttpGet]
        [Authorize(Roles = "HOD")]
        public IActionResult DeleteLeave(int leave_id)
        {
            if (leave_id == 0)
                return RedirectToAction("MyLeave", "HOD");
            //return NotFound();
            var leaveHistory = _context.LeaveHistory.Where(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name).FirstOrDefault();
            if (leaveHistory == null)
            {
                return NotFound();
            }
            int status = DateTime.Compare(leaveHistory.StartFrome, DateTime.Now);
            if (status <= 0)
            {
                return RedirectToAction("MyLeave", "HOD");
            }
            DeleteLeave deleteLeave = new DeleteLeave
            {
                LeaveEndTill = leaveHistory.EndTill,
                LeaveStatus = leaveHistory.LeaveStatus,
                LeaveReason = leaveHistory.LeaveReason,
                LeaveStartFrome = leaveHistory.StartFrome,
                leave_id = leaveHistory.leave_id,
                NoOfDay = leaveHistory.NoOfDay,
            };
            ViewBag.id = leave_id;
            return View(deleteLeave);
        }

        [HttpPost]
        [Authorize(Roles = "HOD")]
        public async Task<IActionResult> DeleteLeave(int leave_id, DeleteLeave deleteLeave)
        {
            //var leaveHistory = await _context.LeaveHistory.FindAsync(leave_id && m.AllUser.Email == User.Identity.Name);
            var leaveHistory = await _context.LeaveHistory
                .Include(l => l.AllUser)
                .FirstOrDefaultAsync(m => m.leave_id == leave_id && m.AllUser.Email == User.Identity.Name);

            if (leaveHistory == null)
                return NotFound();
            var HODuser = _context.AllUser.Where(x => x.Role == "Dean").FirstOrDefault();
            UserEmail userEmail = new UserEmail
            {
                ToEmail = HODuser.Email,

            };
            var arr = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> temp = new KeyValuePair<string, string>("{{username}}", leaveHistory.AllUser.Email);
            //temp.Key = "username";
            //temp.Value = "yashgarala29@gmail.com";
            arr.Add(temp);
            userEmail.PlaceHolder = arr;
            await emailService.SendLeaveCancelEmail(userEmail);

            _context.LeaveHistory.Remove(leaveHistory);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyLeave", "HOD");
        }
    }
}