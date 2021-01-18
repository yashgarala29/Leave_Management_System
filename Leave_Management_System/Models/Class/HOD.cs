using Leave_Management_System.Models.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class HOD
    {
        [Key]
        public int HOD_id { get; set; }
        public IList<LeaveHistory> leaveHistory { get; set; }
    }
}
