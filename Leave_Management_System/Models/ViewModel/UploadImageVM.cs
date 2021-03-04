using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class UploadImageVM
    {
        [Required]
        [Display(Name = "Image")]
        public IFormFile EmployeePicture { get; set; }
    }
}
