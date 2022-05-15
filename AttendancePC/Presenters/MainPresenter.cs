using AttendancePC.Supporting;
using AttendancePC.Views;
using System.Drawing;
using System.Windows.Forms;

namespace AttendancePC.Presenters
{
    public class MainPresenter
    {
        IMainView view;

        #region views
        IView attendance;
        IView schedules;
        IView reports;
        IView authorization;
        IView users;
        IView students;
        IView subjects;
        IView connection;
        IView query;

        public IView Attendance
        {
            set
            {
                attendance = value;
                attendance.FormClosed += Attendance_FormClosed;
            }
            get
            {
                return attendance ?? (Attendance = new AttendanceForm());
            }
        }
        public IView Schedules
        {
            set
            {
                schedules = value;
                schedules.FormClosed += Schedules_FormClosed;
            }
            get
            {
                return schedules ?? (Schedules = new ShedulesForm());
            }
        }

        public IView Reports
        {
            set
            {
                reports = value;
                reports.FormClosed += Reports_FormClosed;
            }
            get
            {
                return reports ?? (Reports = new ReportsForm());
            }
        }

        public IView Authorization
        {
            set
            {
                authorization = value;
                authorization.FormClosed += Authorization_FormClosed;
            }
            get
            {
                return authorization ?? (Authorization = new AuthorizationForm());
            }
        }

        public IView Users
        {
            set
            {
                users = value;
                users.FormClosed += Users_FormClosed;
            }
            get
            {
                return users ?? (Users = new UsersForm());
            }
        }

        public IView Students
        {
            set
            {
                students = value;
                students.FormClosed += Students_FormClosed;
            }
            get
            {
                return students ?? (Students = new StudentsForm());
            }
        }

        public IView Subjects
        {
            set
            {
                subjects = value;
                subjects.FormClosed += Subjects_FormClosed;
            }
            get
            {
                return subjects ?? (Subjects = new SubjectsForm());
            }
        }

        public IView Connection
        {
            set
            {
                connection = value;
                connection.FormClosed += Connection_FormClosed; ;
            }
            get
            {
                return connection ?? (Connection = new ConnectionForm());
            }
        }

        public IView Query
        {
            set
            {
                query = value;
                query.FormClosed += Query_FormClosed; ;
            }
            get
            {
                return query ?? (Query = new QueryForm());
            }
        }
        #endregion

        public MainPresenter(IMainView view)
        {
            this.view = view;
            Global.UserChanged += Global_UserChanged;
        }

        private void Global_UserChanged()
        {
            view.UserName = Global.CurrentUser?.Login ?? "";
            view.Signed = Global.CurrentUser != null;
            view.Attendance = view.Schedules = view.Reports = view.Settings = view.Query = view.Connection = false;
            if (Global.CurrentUser == Global.admin)
            {
                view.Connection = view.Query = view.Settings = true;
                return;
            }
            if (Global.CurrentUser?.Guest != null)
            {
                view.Attendance = true;
                view.Reports = Global.CurrentUser.Guest.IsPrime;
                return;
            }
            if (Global.CurrentUser?.Editor != null)
            {
                view.Attendance = view.Schedules = view.Reports = view.Settings = true;
                return;
            }
        }

        #region formClosed
        private void Schedules_FormClosed(object sender, FormClosedEventArgs e)
        {
            schedules = null;
        }

        private void Attendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            attendance = null;
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            reports = null;
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            students = null;
        }

        private void Query_FormClosed(object sender, FormClosedEventArgs e)
        {
            query = null;
        }

        private void Connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection = null;
        }

        private void Subjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            subjects = null;
        }

        private void Authorization_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            authorization = null;
        }
        #endregion

        public void LoadMain()
        {
            Core.RenewConnectionString();
            view.Attendance = view.Schedules = view.Reports = view.Settings = view.Query = view.Connection = view.Signed = false;
        }
        public void SignOut()
        {
            Global.CurrentUser = null;
            attendance?.Close();
            schedules?.Close();
            reports?.Close();
            users?.Close();
            students?.Close();
            subjects?.Close();
            connection?.Close();
        }

        public void SetStyle(Control control)
        {
            if (control is Form form)
            {
                form.BackColor = Color.AliceBlue;
            }
            else if (control is MdiClient mdi)
            {
                mdi.BackColor = Color.AliceBlue;
            }
            else if(control is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
            }

            foreach (Control item in control.Controls)
            {
                SetStyle(item);
            }
        }
    }
}
