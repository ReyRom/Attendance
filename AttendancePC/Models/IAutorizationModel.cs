using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    internal interface IAutorizationModel
    {
        void CheckUser(string login, string password);
    }
}
