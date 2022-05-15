using System;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class MainForm : Form, IMainView
    {
        Presenters.MainPresenter presenter;

        #region Controls
        public string UserName
        {
            set
            {
                signOutToolStripMenuItem.Text = "Выйти " + value;
            }
        }

        public bool Attendance
        {
            set
            {
                AttendanceToolStripMenuItem.Visible = value;
            }
        }
        public bool Schedules
        {
            set
            {
                SchedulesToolStripMenuItem.Visible = value;
            }
        }
        public bool Reports
        {
            set
            {
                ReportsToolStripMenuItem.Visible = value;
            }
        }
        public bool Connection
        {
            set
            {
                ConnectionToolStripMenuItem.Visible = value;
            }
        }
        public bool Settings
        {
            set
            {
                SettingsToolStripMenuItem.Visible = value;
            }
        }

        public bool Query
        {
            set
            {
                QueryToolStripMenuItem.Visible = value;
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
        #endregion

        public MainForm()
        {
            InitializeComponent();

            presenter = new Presenters.MainPresenter(this);
        }

        private void AttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Attendance.MdiParent = this;
            presenter.Attendance.Show();
            presenter.SetStyle(this);
        }

        private void SchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Schedules.MdiParent = this;
            presenter.Schedules.Show();
            presenter.SetStyle(this);
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Reports.MdiParent = this;
            presenter.Reports.Show();
            presenter.SetStyle(this);
        }

        private void SignInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Authorization.MdiParent = this;
            presenter.Authorization.Show();
            presenter.SetStyle(this);
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.SignOut();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Users.MdiParent = this;
            presenter.Users.Show();
            presenter.SetStyle(this);
        }

        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Students.MdiParent = this;
            presenter.Students.Show();
            presenter.SetStyle(this);
        }

        private void SubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Subjects.MdiParent = this;
            presenter.Subjects.Show();
            presenter.SetStyle(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter.LoadMain();
            presenter.SetStyle(this);
        }

        private void ConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Connection.MdiParent = this;
            presenter.Connection.Show();
            presenter.SetStyle(this);
        }

        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Query.MdiParent = this;
            presenter.Query.Show();
            presenter.SetStyle(this);
        }
    }
}
