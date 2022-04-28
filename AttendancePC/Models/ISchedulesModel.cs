using AttendancePC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    public interface ISchedulesModel
    {
        List<LessonRepresentation> LoadShedule(DateTime date);
        List<LessonRepresentation> LoadShedule(List<LessonRepresentation> data);
        List<string> GetDaysOfWeek();
        List<ScheduleRepresentation> GetShedules();
        List<Subject> GetSubjects();
        void SaveScheduleTemplate(List<LessonRepresentation> lessons, byte dayOfWeek, bool isEven);
        void SaveSchedule(List<LessonRepresentation> lessons);
    }
}
