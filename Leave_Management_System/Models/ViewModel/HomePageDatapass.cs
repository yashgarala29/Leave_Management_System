using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class HomePageDatapass
    {
        public int approveleave { get; set; }
        public int Rejectedleave { get; set; }
        public int Peandingeave { get; set; }
        public int TotalLeave { get; set; }
        public List<KeyValuePair<string, int>> allocatedleave{get;set;} 
    }
}
