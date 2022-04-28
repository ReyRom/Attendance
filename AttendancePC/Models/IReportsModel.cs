using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    internal interface IReportsModel
    {
        DataTable GetSummaryAttendance(DateTime startDate, DateTime endDate);
        void SaveSummaryAttendance( string filename, DataTable summary, DataTable sum);
        DataTable Summary(DateTime startDate, DateTime endDate);
        object GetSummarySubjects(DateTime startDate, DateTime endDate);
    }
}
