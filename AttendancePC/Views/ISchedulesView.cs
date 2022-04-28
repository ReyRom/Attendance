using AttendancePC.Models;
using AttendancePC.Models.Entities;
using System.Collections.Generic;

namespace AttendancePC.Views
{
    public interface ISchedulesView : IView
    {
        object Schedule { set; }
        object DaysOfWeek { set; }
        object Subjects { set; }
        object Schedules { set; }
    }
}
