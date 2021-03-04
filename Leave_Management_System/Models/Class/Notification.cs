using Leave_Management_System.Models.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.Class
{
    public class Notification
    {
        [Key]
       public int NotificationID { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool isreaded { get; set; }
        public int id { get; set; }
        [ForeignKey("id")]
        public AllUser AllUser { get; set; }
    }
}
