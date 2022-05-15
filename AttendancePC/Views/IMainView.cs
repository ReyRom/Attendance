namespace AttendancePC.Views
{
    public interface IMainView : IView
    {
        string UserName
        {
            set;
        }
        bool Attendance
        {
            set;
        }
        bool Reports
        {
            set;
        }
        bool Connection
        {
            set;
        }
        bool Settings
        {
            set;
        }

        bool Signed
        {
            set;
        }
        bool Schedules
        {
            set;
        }
        bool Query
        {
            set;
        }
    }
}
