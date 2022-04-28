using AttendancePC.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class AuthorizationForm : Form, IAuthorizationView
    {
        AuthorizationPresenter presenter;

        public string Login
        {
            get 
            {
                return LoginTextBox.Text;
            }
        }
        public string Password
        {
            get
            {
                return PasswordTextBox.Text;
            }
        }

        public AuthorizationForm()
        {
            InitializeComponent();

            presenter = new AuthorizationPresenter(this);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            presenter.CheckUser();
        }
    }
}
