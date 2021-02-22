
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Leave_Management_System.Models.Class
{
    public class AllUser
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string UserImage { get; set; }
        [Display(Name = "Mobile Number 1")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int MobileNo { get; set; }

        [Display(Name = "Mobile Number 2")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int MobileNo2 { get; set; }

        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        public string Deparment { get; set; }
        public string Role { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Addreaddress { get; set; }
 
        public string City { get; set; }

        public int PaidLeave { get; set; }

        public IList<LeaveHistory> leaveHistory { get; set; }

    }
}
