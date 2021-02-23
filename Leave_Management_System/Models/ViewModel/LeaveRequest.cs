using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class LeaveRequest
    {
        public int id { get; set; }
        [Display(Name = "Leave Type")]
        public string LeaveType { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string LeaveReason { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Frome")]
        public DateTime LeaveStartFrome { get; set;}
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="End Till")]
        public DateTime LeaveEndTill { get; set; }

    }
}
