using AttendancePC.Models.Entities;
using AttendancePC.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Supporting
{
    public static class Global
    {
        public delegate void EventHandler();
        public static event EventHandler DataChanged;
        private static User currentUser;
        public static event EventHandler UserChanged;

        private static DateTime currentDate = DateTime.Now.Date;

        public static DateTime CurrentDate
        {
            get => currentDate;
            set
            {
                currentDate = value;
                DataChanged?.Invoke();
            }
        }

        public static readonly Subject nullSubject = new Subject() { IdSubject = 0, Name = "" };

        public static void InitializePresenter(IPresenter presenter)
        {
            presenter.RenewEvent += Presenter_RenewEvent;
        }

        private static void Presenter_RenewEvent(object sender, EventArgs e)
        {
            DataChanged?.Invoke();
        }

        public static User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                UserChanged?.Invoke();
            }
        }

        public static User admin = new User() { IdUser = 0, Login = "admin" };
        public static string adminLogin = "admin";
        public static string adminPassword = "admin";
    }
}
