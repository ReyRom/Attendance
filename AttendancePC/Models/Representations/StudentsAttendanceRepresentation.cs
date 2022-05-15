using AttendancePC.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AttendancePC.Models
{
    internal class StudentsAttendanceRepresentation
    {

        private List<AttendRepresentation> attends;
        public string Name { get; set; }
        public List<AttendRepresentation> Attends
        {
            get
            {
                return attends ?? (attends = GetAttend());
            }
        }
        public AttendRepresentation Pair1 { get => Attends.ElementAtOrDefault(0) ?? new AttendRepresentation(); }
        public AttendRepresentation Pair2 { get => Attends.ElementAtOrDefault(1) ?? new AttendRepresentation(); }
        public AttendRepresentation Pair3 { get => Attends.ElementAtOrDefault(2) ?? new AttendRepresentation(); }
        public AttendRepresentation Pair4 { get => Attends.ElementAtOrDefault(3) ?? new AttendRepresentation(); }
        public AttendRepresentation Pair5 { get => Attends.ElementAtOrDefault(4) ?? new AttendRepresentation(); }
        public AttendRepresentation Pair6 { get => Attends.ElementAtOrDefault(6) ?? new AttendRepresentation(); }

        public Student Student { get; set; }
        public List<LessonAttend> LessonAttends { get; set; }
        public List<Lesson> Lessons { get; set; }

        public List<AttendRepresentation> GetAttend()
        {
            byte firstPair = 0;
            byte lastPair = 0;
            var Attends = new List<AttendRepresentation>();

            if (Lessons.Count!=0)
            {
                firstPair = Lessons.Min(l => l.OrderNumber);
                lastPair = Lessons.Max(l => l.OrderNumber);

                for (int i = 1; i < firstPair; i++)
                {
                    Attends.Add(new AttendRepresentation());
                }
                for (int i = firstPair; i <= lastPair; i++)
                {
                    if (LessonAttends.Exists(a => a.Lesson.OrderNumber == i))
                    {
                        var attend = LessonAttends.Where(a => a.Lesson.OrderNumber == i).First();
                        Attends.Add(new AttendRepresentation
                        {
                            AttendChar = attend.AttendChar,
                            IdLesson = attend.IdLesson,
                            IdStudent = attend.IdStudent,
                            IsReasonable = attend.IsReasonable
                        });
                    }
                    else
                    {
                        Attends.Add(new AttendRepresentation
                        {
                            AttendChar = "+",
                            IdLesson = Lessons.Where(l => l.OrderNumber == i).First().IdLesson,
                            IdStudent = Student.IdStudent,
                            IsReasonable = null
                        });
                    }
                }
            }
            return Attends;
        }
    }
}
