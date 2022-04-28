using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendancePC.Models
{
    public class StudentsModel: IStudentsModel
    {
        public List<Student> GetStudents()
        {
            return Core.Context.Students.Where(x => !x.IsDismissed).ToList();
        }
        public List<Student> GetDismissedStudents()
        {
            return Core.Context.Students.Where(x => x.IsDismissed).ToList();
        }
        public void AddStudent(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
            Student student = new Student();
            student.Name = name;
            student.IsDismissed = false;
            Core.Context.Students.Add(student);
            Core.Context.SaveChanges();
        }

        public void DeleteStudent(object student)
        {
            if (!(student is Student))
            {
                return;
            }
            Core.Context.Students.Remove(student as Student);
            Core.Context.SaveChanges();
        }

        public void RecoverStudent(object item)
        {
            throw new NotImplementedException();
        }
    }
}
