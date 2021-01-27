using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class OwnProfile
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        
        [Display(Name = "Mobile Number")]
        [DataType(DataType.Text)]
        public int MobileNo { get; set; }

        [Display(Name = "Mobile Number 2")]
        [DataType(DataType.Text)]
        public int MobileNo2 { get; set; }

        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

       
        [DataType(DataType.MultilineText)]
        public string Addreaddress { get; set; }

        public string City { get; set; }
        
        public int PaidLeave { get; set; }
    }
}
