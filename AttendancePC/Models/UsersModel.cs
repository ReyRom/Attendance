using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Linq;

namespace AttendancePC.Presenters
{
    internal class UsersModel : IUsersModel
    {
        public void AddGuest(string login, bool isPrime)
        {
            try
            {
                Core.Context.AddGuest(login, isPrime);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddRedactor(string login, string password)
        {
            try
            {
                Core.Context.AddRedactor(login, password);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteGuest(object item)
        {
            try
            {
                Core.Context.Guests.Remove((item as User).Guest);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteRedactor(object item)
        {
            try
            {
                Core.Context.Editors.Remove((item as User).Editor);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetGuests()
        {
            try
            {
                return Core.Context.Guests.Select(x => x.User).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetRedactors()
        {
            try
            {
                return Core.Context.Editors.Select(x => x.User).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}