using AttendancePC.Supporting;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Presenters
{
    public class ConnectionPresenter
    {
        IConnectionView view;
        public ConnectionPresenter(IConnectionView view)
        {
            this.view = view;
        }

        public void SaveConnection()
        {
            Core.Server = view.Server;
            Core.Database = view.DataBase;
            Core.Login = view.Login;
            Core.Password = view.Password;
            Core.RenewConnectionString();
        }

        public void LoadConnectionInfo() 
        {
            view.Server = Core.Server;
            view.DataBase = Core.Database;
            view.Login = Core.Login;
            view.Password = Core.Password;
        }
    }
}
