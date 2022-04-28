using AttendancePC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    public interface IAttendanceModel
    {
        DataTable LoadAttends(DateTime date, Student filter);
        List<string> GetDayPairs(DateTime date);
        void SetAttendChar(AttendRepresentation item);
        void SetReasonable(AttendRepresentation item);
        object LoadStudents();
    }
}
