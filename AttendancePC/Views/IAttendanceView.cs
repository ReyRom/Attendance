using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Views
{
    internal interface IAttendanceView : IView
    {
        object Data { set; }
        object[] Headers { set; }
        DateTime Date { set; get; }
        object Students { set; }
        object Filter { get; }
    }
}
