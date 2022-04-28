using AttendancePC.Views;
using AttendancePC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Presenters
{
    internal class AuthorizationPresenter
    {
        IAuthorizationView view;
        IAutorizationModel model;

        public AuthorizationPresenter(IAuthorizationView view)
        {
            this.view = view;
            model = new AuthorizationModel();
        }

        public void CheckUser()
        {
            try
            {
                model.CheckUser(view.Login, view.Password);
                MessageBox.Show("Вход выполнен!");
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
