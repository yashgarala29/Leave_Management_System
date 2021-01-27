using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class ListOfLeaveRequestHOD
    {
        public int id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Username")]
        public string username { get; set; }
        [Display(Name = "Start Frome")]
        public DateTime LeaveStartFrome { get; set;}
        [Display(Name = "End Till")]
        public DateTime LeaveEndTill { get; set; }
        [Display(Name ="No Of Day")]
        public int NoOfDay { get; set; }
        [Display(Name = "Status")]
        public List<string> Status { get; set; }
        [Display(Name = "Leave Reason")]
        public string LeaveReason { get; set; }

    }
}
