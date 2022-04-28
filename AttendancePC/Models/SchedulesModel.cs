using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    internal class SchedulesModel : ISchedulesModel
    {
        public List<LessonRepresentation> LoadShedule(DateTime date)
        {
            var lessonsList = new List<LessonRepresentation>();
            var data = Core.Context.Days.Where(d => DbFunctions.DiffDays(d.Date, Global.CurrentDate) == 0).FirstOrDefault()?.Lessons.ToList();
            for (int i = 1; i <= 6; i++)
            {
                lessonsList.Add(new LessonRepresentation()
                {
                    OrderNumber = (byte)i,
                    IdSubject = data?.Where(l => l.OrderNumber == i).FirstOrDefault()?.IdSubject ?? Global.nullSubject.IdSubject
                });
            }
            return lessonsList;
        }
        public List<LessonRepresentation> LoadShedule(List<LessonRepresentation> data)
        {
            var lessonsList = new List<LessonRepresentation>();
            for (int i = 1; i <= 6; i++)
            {
                lessonsList.Add(new LessonRepresentation()
                {
                    OrderNumber = (byte)i,
                    IdSubject = data?.Where(l => l.OrderNumber == i).FirstOrDefault()?.IdSubject ?? Global.nullSubject.IdSubject
                });
            }
            return lessonsList;
        }

        public List<string> GetDaysOfWeek()
        {
            var daysOfWeek = new List<string>();
            for (int i = 1; i <= 6; i++)
            {
                daysOfWeek.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)i));
            }
            return daysOfWeek;
        }
        public List<ScheduleRepresentation> GetShedules()
        {
            var sheduleList = Core.Context.Schedules.GroupBy(s => new { s.DayOfWeek, s.IsEven })
                .Select(gr => new ScheduleRepresentation
                {
                    DayOfWeek = (DayOfWeek)gr.Key.DayOfWeek,
                    IsEven = gr.Key.IsEven,
                    Lessons = gr.Select(x => new LessonRepresentation { IdSubject = x.IdSubject, OrderNumber = x.OrderNumber }).ToList()
                }).ToList();
            return sheduleList;
        }
        
        public List<Subject> GetSubjects()
        {
            var subjectsList = Core.Context.Subjects.ToList();
            subjectsList.Insert(0, Global.nullSubject);
            return subjectsList;
        }
        public void SaveScheduleTemplate(List<LessonRepresentation> lessons, byte dayOfWeek, bool isEven )
        {
            lessons.RemoveAll(l => l.IdSubject == Global.nullSubject.IdSubject);
            Core.Context.Schedules.RemoveRange(Core.Context.Schedules.Where(s => s.DayOfWeek == dayOfWeek && s.IsEven == isEven));
            Core.Context.SaveChanges();

            foreach (var item in lessons)
            {
                Core.Context.Schedules.Add(new Schedule
                {
                    DayOfWeek = dayOfWeek,
                    IdSubject = item.IdSubject,
                    OrderNumber = item.OrderNumber,
                    IsEven = isEven,
                });
            }
            Core.Context.SaveChanges();
        }
        public void SaveSchedule(List<LessonRepresentation> lessons)
        {
            lessons = lessons.OrderBy(l => l.OrderNumber)
                .SkipWhile(l => l.IdSubject == Global.nullSubject.IdSubject)
                .TakeWhile(l => l.IdSubject != Global.nullSubject.IdSubject).ToList();
            Day day;

            day = Core.Context.Days.Where(d => DbFunctions.DiffDays(d.Date, Global.CurrentDate) == 0).FirstOrDefault();
            if (day != null)
            {
                if (lessons.Count == 0)
                {
                    Core.Context.Days.Remove(day);
                    Core.Context.SaveChanges();
                    return;
                }
                day.FirstPair = lessons.FirstOrDefault().OrderNumber;
                day.LastPair = lessons.LastOrDefault().OrderNumber;
            }
            else
            {
                if (lessons.Count == 0)
                {
                    return;
                }
                day = Core.Context.Days.Add(new Models.Entities.Day
                {
                    Date = Global.CurrentDate,
                    FirstPair = lessons.FirstOrDefault().OrderNumber,
                    LastPair = lessons.LastOrDefault().OrderNumber
                });
            }


            var lessonsToDelete = day.Lessons.Where(l => !lessons
                .Exists(x => x.IdSubject == l.IdSubject && x.OrderNumber == l.OrderNumber)).ToList();

            foreach (var lesson in lessonsToDelete)
            {
                Core.Context.Lessons.Remove(lesson);
            }
            foreach (var lesson in lessons)
            {
                day.Lessons.Add(new Lesson { IdSubject = lesson.IdSubject, OrderNumber = lesson.OrderNumber });
            }

            Core.Context.SaveChanges();
        }
    }   
}

