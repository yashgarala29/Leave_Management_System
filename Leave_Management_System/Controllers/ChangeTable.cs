using Leave_Management_System.Models.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class ChangeTable
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly LeaveDbContext _context;
        public ChangeTable(LeaveDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this._context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        Object[] alldata = new Object[6];
        public void changeRole(string user_role, string new_role, IdentityUser user)
        {
            string user_name = user.Email;
            if (user_role == "Dean")
                removeToDean(user, user_name);
            else if (user_role == "Faculty")
                removeToFaculty(user, user_name);
            else if (user_role == "HOD")
                removeToHOD(user, user_name);
            else if (user_role == "Registrar")
                removeToRegistrar(user, user_name);

            if (user_role == "Dean")
                addToDean(user, user_name);
            else if (user_role == "Faculty")
                addToFaculty(user, user_name);
            else if (user_role == "HOD")
                addToHOD(user, user_name);
            else if (user_role == "Registrar")
                addToRegistrar(user, user_name);


        }

        public void addToHOD(IdentityUser user, string user_name)
        {

        }
        public void addToFaculty(IdentityUser user, string user_name)
        {

        }
        public void addToRegistrar(IdentityUser user, string user_name)
        {

        }
        public void addToDean(IdentityUser user, string user_name)
        {

        }

        public void removeToHOD(IdentityUser user, string user_name)
        {
            //var user_detail= _context.HOD.Where(x => x.Email == user_name).FirstOrDefault();
            // alldata[0] = user_detail.Email;
            // alldata[1] = user_detail.FirstName;
            // alldata[2] = user_detail.LastName;
            // alldata[3] = user_detail.MobileNo;
            // alldata[4] = user_detail.Deparment;
            // alldata[5] = user_detail.FreeLeave;


        }
        public void removeToFaculty(IdentityUser user, string user_name)
        {

        }
        public void removeToRegistrar(IdentityUser user, string user_name)
        {

        }
        public void removeToDean(IdentityUser user, string user_name)
        {

        }

    }
}
