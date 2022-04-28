using AttendancePC.Models;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Presenters
{
    public class MainPresenter
    {
        IMainView view;

        IView attendance;
        IView schedules;
        IView reports;
        IView authorization;
        IView users;
        IView students;
        IView subjects;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            Global.UserChanged += Global_UserChanged;
        }

        private void Global_UserChanged()
        {
            view.UserName = Global.CurrentUser?.Login ?? "";
            view.Signed = Global.CurrentUser != null;
            view.Attendance = view.Schedules = view.Reports = view.Settings = view.Connection = false;
            if (Global.CurrentUser == Global.admin)
            {
                view.Signed = view.Connection = true;
                return;
            }
            if (Global.CurrentUser?.Guest != null)
            {
                view.Attendance = true;
                return;
            }
            if (Global.CurrentUser?.Redactor != null)
            {
                view.Attendance = view.Schedules = view.Reports = view.Settings = view.Signed = true;
                return;
            }
        }

        private void Schedules_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            schedules = null;
        }

        private void Attendance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            attendance = null;
        }

        private void Reports_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            reports = null;
        }

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

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
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

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            students = null;
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

        private void Subjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            subjects = null;
        }

        private void Authorization_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            authorization = null;
        }

        internal void LoadMain()
        {
            view.Attendance = view.Schedules = view.Reports = view.Settings = view.Connection = view.Signed = false;
        }
        internal void SignOut()
        {
            Global.CurrentUser = null;
            attendance?.Close();
            schedules?.Close();
            reports?.Close();
            users?.Close();
            students?.Close();
            subjects?.Close();
        }
    }
}
