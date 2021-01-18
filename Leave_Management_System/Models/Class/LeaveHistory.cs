using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Class
{
    public class LeaveHistory
    {
        [Key]
        public int leave_id { get; set; }

        public int Registrar_id { get; set; }
        [ForeignKey("Registrar_id")]
        public Registrar ragistrar { get; set; }

        public int HOD_id { get; set; }
        [ForeignKey("HOD_id")]
        public HOD hod { get; set; }

        public int Faculty_id { get; set; }
        [ForeignKey("Faculty_id")]
        public Faculty faculty { get; set; }

        public int Dean_id { get; set; }
        [ForeignKey("Dean_id")]
        public Dean dean { get; set; }



    }
}
