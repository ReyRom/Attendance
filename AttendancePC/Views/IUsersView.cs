namespace AttendancePC.Views
{
    internal interface IUsersView: IView
    {
        object Guests { set; }
        object Redactors { set; }
    }
}