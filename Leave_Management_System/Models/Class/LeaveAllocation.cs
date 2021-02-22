using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Class
{
    public class LeaveAllocation
    {
        [Key]
        public int AllocationID { get; set; }
        public int NoOfLeave { get; set; }
        public int id { get; set; }
        [ForeignKey("id")]
        public AllUser AllUser { get; set; }

        public int leaveTypeID { get; set; }
        [ForeignKey("leaveTypeID")]
        public leaveType leaveType { get; set; }

    }
}
