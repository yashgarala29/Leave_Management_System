using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Class
{
    public class Faculty
    {
        [Key]
        public int Faculty_id { get; set; }
        [Display(Name = "Mobile Number")]
        [DataType(DataType.Text)]
        [MaxLength(10), MinLength(10)]
        public int MobileNo { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Deparment { get; set; }
        public int FreeLeave { get; set; }

        public IList<LeaveHistory> leaveHistory { get; set; }
    }
}
