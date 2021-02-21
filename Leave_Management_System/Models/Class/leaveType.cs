using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Class
{
    public class leaveType
    {
        [Key]
        public int leaveTypeID { get; set; }
        public string LeaveType { get; set; }
        public bool allcatoToAll { get; set; }
          
    }
}
