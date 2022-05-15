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
            try
            {
                if (Global.adminLogin == login && Global.adminPassword == password)
                {
                    Global.CurrentUser = Global.admin;
                    return;
                }
                var user = Core.Context.Users.FirstOrDefault(u => u.Login == login);
                if (user == null)
                {
                    throw new Exception("Введены некорректные учетные данные");
                }
                if (user.Editor != null)
                {
                    if (user.Editor.Password != password)
                    {
                        throw new Exception("Указан неверный пароль");
                    }
                }
                Global.CurrentUser = user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
