using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class forgotpasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set;}
    }
}
