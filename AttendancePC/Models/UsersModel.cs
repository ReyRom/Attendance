using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System.Linq;

namespace AttendancePC.Presenters
{
    internal class UsersModel : IUsersModel
    {
        public void AddGuest(string login, bool isPrime)
        {
            Core.Context.AddGuest(login, isPrime);
            Core.Context.SaveChanges();
        }

        public void AddRedactor(string login, string password)
        {
            Core.Context.AddRedactor(login, password);
            Core.Context.SaveChanges();
        }

        public void DeleteGuest(object item)
        {
            Core.Context.Guests.Remove((item as Guest));
            Core.Context.Users.Remove((item as Guest).User);
            Core.Context.SaveChanges();
        }

        public void DeleteRedactor(object item)
        {
            Core.Context.Redactors.Remove((item as Redactor));
            Core.Context.Users.Remove((item as Redactor).User);
            Core.Context.SaveChanges();
        }

        public object GetGuests()
        {
            return Core.Context.Guests.Select(x => x.User).ToList();
        }

        public object GetRedactors()
        {
            return Core.Context.Redactors.Select(x => x.User).ToList();
        }
    }
}