using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

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
        object[] DiagramSource
        {
            set;
        }
        Chart Diagram
        {
            get;
        }
    }
}
