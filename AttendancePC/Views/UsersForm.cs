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
    public partial class UsersForm : Form, IUsersView
    {
        UsersPresenter presenter;

        #region Controls
        public object Guests
        {
            set 
            { 
                GuestsListBox.DataSource = value;
            }
        }
        public object Redactors
        {
            set
            {
                RedactorsListBox.DataSource = value;
            }
        }
        #endregion

        public UsersForm()
        {
            InitializeComponent();
            presenter = new UsersPresenter(this);

            GuestsListBox.DisplayMember = "Login";
            RedactorsListBox.DisplayMember = "Login";
        }

        private void DeleteGuestButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteGuest(GuestsListBox.SelectedItem);
        }

        private void DeleteRedactorButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteRedactor(RedactorsListBox.SelectedItem);
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            presenter.AddGuest(GuestLoginTextBox.Text, IsPrimeCheckBox.Checked);
        }

        private void AddRedactorButton_Click(object sender, EventArgs e)
        {
            presenter.AddRedactor(RedactorLoginTextBox.Text, PasswordTextBox.Text);
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
    }
}
