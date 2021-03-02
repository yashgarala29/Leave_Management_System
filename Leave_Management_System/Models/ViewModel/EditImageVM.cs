using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class EditImageVM : UploadImageVM
    {
        public int Id { get; set; }
        public string ExistingImage { get; set; }
    }
}
