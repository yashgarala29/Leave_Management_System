using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Class
{
    public class Registrar
    {
        [Key]
        public int Registrar_id { get; set; }
        public IList<LeaveHistory> leaveHistory { get; set; }

    }
}
