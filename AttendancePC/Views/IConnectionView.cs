using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Views
{
    public interface IConnectionView : IView
    {
        string Server
        {
            get;
            set;
        }
        string DataBase
        {
            get;
            set;
        }
        string Login
        {
            get;
            set;
        }
        string Password
        {
            get;
            set;
        }
    }
}
