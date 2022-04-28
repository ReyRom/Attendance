using System.Data;

namespace AttendancePC.Views
{
    internal interface IReportsView : IView
    {
        object SummaryAttendance
        {
            set;
        }
        object SumAttendance
        {
            set;
        }
        object SummarySubjects
        {
            set;
        }
    }
}
