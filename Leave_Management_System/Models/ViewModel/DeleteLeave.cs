using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class DeleteLeave
    {
        [Key]
        public int leave_id { get; set; }
        [Display(Name = "Start Reason")]
        public string LeaveReason { get; set; }

        [Display(Name = "Start Status")]
        public string LeaveStatus { get; set; }

        [Display(Name = "Start Frome")]
        public DateTime LeaveStartFrome { get; set; }
        
        [Display(Name = "End Till")]
        public DateTime LeaveEndTill { get; set; }
        [Display(Name = "No Of Day")]
        public int NoOfDay { get; set; }

    }
}
