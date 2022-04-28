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
            model.DeleteGuest(item);
            LoadData();
        }

        internal void DeleteRedactor(object item)
        {
            model.DeleteRedactor(item);
            LoadData();
        }

        internal void AddGuest(string login, bool isPrime)
        {
            model.AddGuest(login, isPrime);
            LoadData();
        }

        internal void AddRedactor(string login, string password)
        {
            model.AddRedactor(login, password);
            LoadData();
        }

        internal void LoadData()
        {
            view.Guests = model.GetGuests();
            view.Redactors = model.GetRedactors();
        }
    }
}