using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendancePC.Models
{
    public class StudentsModel : IStudentsModel
    {
        public List<Student> GetStudents()
        {
            try
            {
                return Core.Context.Students.Where(x => !x.IsDismissed).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Student> GetDismissedStudents()
        {
            try
            {
                return Core.Context.Students.Where(x => x.IsDismissed).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void AddStudent(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException();
                }
                Student student = new Student();
                student.Name = name;
                student.IsDismissed = false;
                Core.Context.Students.Add(student);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteStudent(object student)
        {
            try
            {
                if (!(student is Student))
                {
                    return;
                }
                Core.Context.Students.Remove(student as Student);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RecoverStudent(object item)
        {
            try
            {
                if (!(item is Student))
                {
                    return;
                }
                var student = Core.Context.Students.Find((item as Student).IdStudent);
                student.IsDismissed = false;
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
