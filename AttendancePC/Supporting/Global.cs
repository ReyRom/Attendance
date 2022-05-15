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
        #region Observer
        public delegate void ObserverEventHandler();
        public static event ObserverEventHandler DataChanged;

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

        public static void InitializePresenter(IPresenter presenter)
        {
            presenter.RenewEvent += Presenter_RenewEvent;
        }

        private static void Presenter_RenewEvent(object sender, EventArgs e)
        {
            DataChanged?.Invoke();
        }

        #endregion

        public static readonly Subject nullSubject = new Subject() { IdSubject = 0, Name = "" };

        #region User

        private static User currentUser;
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

        public static event ObserverEventHandler UserChanged;

        #endregion
    }
}
