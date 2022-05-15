using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace AttendancePC.Models
{
    public class AttendanceModel : IAttendanceModel
    {
        public DataTable LoadAttends(DateTime date, Student filter, int order)
        {
            try
            {
                DataTable table = new DataTable();
                var count = Core.Context.Days.Where(d => DbFunctions.DiffDays(d.Date, date) == 0).FirstOrDefault()?.LastPair ?? 0;
                var data = Core.Context.Students.Where(s => !s.IsDismissed)
                    .Where(s => s.IdStudent == filter.IdStudent || filter.IdStudent == 0)
                    .Select(s => new StudentsAttendanceRepresentation
                    {
                        Name = s.Name,
                        Student = s,
                        LessonAttends = s.LessonAttends.Where(d => DbFunctions.DiffDays(d.Lesson.Day.Date, date) == 0).ToList(),
                        Lessons = Core.Context.Lessons.Where(d => DbFunctions.DiffDays(d.Day.Date, date) == 0).ToList()
                    }).ToList();

                switch (order)
                {
                    case 0:
                        break;
                    case 1:
                        data = data.OrderBy(d => d.Name).ToList();
                        break;
                    case 2:
                        data = data.OrderByDescending(d => d.Name).ToList();
                        break;
                }

                DataColumn dataColumn = new DataColumn();
                table.Columns.Add(new DataColumn("Name", typeof(string)));
                for (int i = 1; i <= 6; i++)
                {
                    table.Columns.Add(new DataColumn($"Pair{i}", typeof(AttendRepresentation)));
                }
                foreach (var d in data)
                {
                    table.Rows.Add(d.Name, d.Pair1, d.Pair2, d.Pair3, d.Pair4, d.Pair5, d.Pair6);
                }
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDayPairs(DateTime date)
        {
            try
            {
                var pairs = new List<string>();
                for (int i = 1; i <= 6; i++)
                {
                    pairs.Add(Core.Context.Lessons.Where(x => DbFunctions.DiffDays(x.Day.Date, date) == 0 && x.OrderNumber == i)
                        .Select(x => x.Subject.Name).FirstOrDefault() ?? "-");
                }
                return pairs;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void SetAttendChar(AttendRepresentation item)
        {
            try
            {
                switch (item.AttendChar)
                {
                    case "+":
                        Core.Context.LessonAttends.Add(new LessonAttend
                        {
                            AttendChar = "-",
                            IsReasonable = false,
                            IdLesson = (int)item.IdLesson,
                            IdStudent = (int)item.IdStudent
                        });
                        Core.Context.SaveChanges();
                        break;
                    case "-":
                        Core.Context.LessonAttends.Find(item.IdLesson, item.IdStudent).AttendChar = "/";
                        Core.Context.SaveChanges();
                        break;
                    case "/":
                        Core.Context.LessonAttends.Remove(Core.Context.LessonAttends.Find(item.IdLesson, item.IdStudent));
                        Core.Context.SaveChanges();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void SetReasonable(AttendRepresentation item)
        {
            try
            {
                switch (item.AttendChar)
                {
                    case "/":
                    case "-":
                        var attend = Core.Context.LessonAttends.Find(item.IdLesson, item.IdStudent);
                        attend.IsReasonable = !attend.IsReasonable;
                        Core.Context.SaveChanges();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object LoadStudents()
        {
            try
            {
                var list = Core.Context.Students.Where(s => !s.IsDismissed).ToList();
                list.Insert(0, new Student() { Name = "Без учета" });
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
