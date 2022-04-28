namespace AttendancePC.Presenters
{
    internal interface IUsersModel
    {
        object GetGuests();
        object GetRedactors();
        void AddRedactor(string login, string password);
        void AddGuest(string login, bool isPrime);
        void DeleteGuest(object item);
        void DeleteRedactor(object item);
    }
}