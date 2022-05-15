using AttendancePC.Supporting;
using AttendancePC.Views;
using System;

namespace AttendancePC.Presenters
{
    internal class UsersPresenter
    {
        IUsersView view;
        IUsersModel model;

        public UsersPresenter(IUsersView view)
        {
            this.view = view;
            model = new UsersModel();
        }

        internal void DeleteGuest(object item)
        {
            try
            {
                model.DeleteGuest(item);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        internal void DeleteRedactor(object item)
        {
            try
            {
                model.DeleteRedactor(item);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        internal void AddGuest(string login, bool isPrime)
        {
            try
            {
                model.AddGuest(login, isPrime);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        internal void AddRedactor(string login, string password)
        {
            try
            {
                model.AddRedactor(login, password);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        internal void LoadData()
        {
            try
            {
                view.Guests = model.GetGuests();
                view.Redactors = model.GetRedactors();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}