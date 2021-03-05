using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class MyLeave 
    {
        [Key]
        public int leave_id { get; set; }
        public string LeaveStatus { get; set; }
        [DataType(DataType.Text)]
        public int NoOfDay { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Leave Reason")]
        public string LeaveReason { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Leave Type")]
        public string LeaveType { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Leave Start Frome")]
        public DateTime StartFrome { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Leave End Till")]
        public DateTime EndTill { get; set; }

        public string Attachment { get; set; }
        public int changeable { get; set; } 

    }
}
