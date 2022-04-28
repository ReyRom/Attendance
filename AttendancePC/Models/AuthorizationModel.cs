using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    internal class AuthorizationModel : IAutorizationModel
    {
        public void CheckUser(string login, string password)
        {
            if (Global.adminLogin == login && Global.adminPassword == password)
            {
                Global.CurrentUser = Global.admin;
                return;
            }
            var user = Core.Context.Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
            {
                throw new Exception();
            }
            if (user.Redactor != null)
            {
                if (user.Redactor.Password != password)
                {
                    throw new Exception();
                }
            }
            Global.CurrentUser = user;
        }
    }
}
