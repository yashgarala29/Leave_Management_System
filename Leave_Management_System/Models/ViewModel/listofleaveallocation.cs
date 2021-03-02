using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class listofleaveallocation
    {
        [Key]
        public int AllocationID { get; set; }
        public int NoOfLeave { get; set; }
        public string leavetype { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
