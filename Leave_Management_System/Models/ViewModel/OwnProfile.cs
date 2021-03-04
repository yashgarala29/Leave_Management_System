using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class OwnProfile : EditImageVM
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile Number 1")]
        public string MobileNo { get; set; }

        [Required]
        [Display(Name = "Mobile Number 2")]
        public string MobileNo2 { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Addreaddress { get; set; }

        [Required]
        public string City { get; set; }

        public int PaidLeave { get; set; }
    }
}
