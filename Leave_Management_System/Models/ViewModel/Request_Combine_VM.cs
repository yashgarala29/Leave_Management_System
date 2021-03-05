using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class Request_Combine_VM
    {
        public LeaveRequest LeaveRequest { get; set; }
        public listofleaveallocation listofleaveallocation { get; set; }
    }
}
