using AttendancePC.Views;
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
    public partial class MainForm : Form, IMainView
    {
        Presenters.MainPresenter presenter;

        public string UserName
        {
            set
            {
                signOutToolStripMenuItem.Text = "SignOut "+value;
            }
        }

        public bool Attendance
        {
            set
            {
                attendanceToolStripMenuItem.Visible = value;
            }
        }
        public bool Schedules
        {
            set
            {
                schedulesToolStripMenuItem.Visible = value;
            }
        }
        public bool Reports
        {
            set
            {
                reportsToolStripMenuItem.Visible = value;
            }
        }
        public bool Connection
        {
            set
            {
                connectionToolStripMenuItem.Visible = value;
            }
        }
        public bool Settings
        {
            set
            {
                settingsToolStripMenuItem.Visible = value;
            }
        }

        public bool Signed
        {
            set
            {
                signOutToolStripMenuItem.Visible = value;
                signInToolStripMenuItem.Visible = !value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            presenter = new Presenters.MainPresenter(this);
        }

        private void AttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Attendance.MdiParent = this;
            presenter.Attendance.Show();
        }

        private void SchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Schedules.MdiParent = this;
            presenter.Schedules.Show();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Reports.MdiParent = this;
            presenter.Reports.Show();
        }

        private void SignInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Authorization.MdiParent = this;
            presenter.Authorization.Show();
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.SignOut();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Users.MdiParent = this;
            presenter.Users.Show();
        }

        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Students.MdiParent = this;
            presenter.Students.Show();
        }

        private void SubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Subjects.MdiParent = this;
            presenter.Subjects.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter.LoadMain();
        }
    }
}
