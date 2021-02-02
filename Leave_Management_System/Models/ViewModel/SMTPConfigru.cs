using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models.ViewModel
{
    public class SMTPConfigru
    {
        public string SenderAddress { get; set; }
        public string SenderDisplyName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }
        public bool UserDefaultCredentils { get; set; }
        public bool IsBodyHTML { get; set; }


    }
}
