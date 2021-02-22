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
        
        
        [Display(Name = "Mobile Number 1")]
        //[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNo { get; set; }

        [Display(Name = "Mobile Number 2")]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNo2 { get; set; }

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
