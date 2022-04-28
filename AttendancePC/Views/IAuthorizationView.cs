namespace AttendancePC.Views
{
    public interface IAuthorizationView : IView
    {
        string Login { get; }
        string Password { get; }
    }
}
