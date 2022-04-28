using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    public class ScheduleRepresentation
    {
        public DayOfWeek DayOfWeek { get; set; }
        public bool IsEven { get; set; }
        public string Name 
        { 
            get 
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DayOfWeek)+(IsEven?" ж":" з");
            } 
        }
        public List<LessonRepresentation> Lessons { get; set; }
    }
}
