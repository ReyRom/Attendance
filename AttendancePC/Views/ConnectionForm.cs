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
    public partial class ConnectionForm : Form, IConnectionView
    {
        ConnectionPresenter presenter;
        public string Server
        {
            get => ServerTextBox.Text;
            set => ServerTextBox.Text = value;
        }
        public string DataBase
        {
            get => DataBaseTextBox.Text;
            set => DataBaseTextBox.Text = value;
        }
        public string Login
        {
            get => LoginTextBox.Text;
            set => LoginTextBox.Text = value;
        }
        public string Password
        {
            get => PasswordTextBox.Text;
            set => PasswordTextBox.Text = value;
        }

        public ConnectionForm()
        {
            InitializeComponent();
            presenter = new ConnectionPresenter(this);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            presenter.SaveConnection();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            presenter.LoadConnectionInfo();
        }
    }
}
