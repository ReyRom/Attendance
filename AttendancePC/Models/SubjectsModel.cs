using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Linq;

namespace AttendancePC.Models
{
    public class SubjectsModel : ISubjectsModel
    {
        public void AddSubject(string name)
        {
            try
            {
                Core.Context.Subjects.Add(new Subject { Name = name, IsActual = true });
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteSubject(object item)
        {
            try
            {
                Core.Context.Subjects.Remove(item as Subject);
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetNonActualSubjects()
        {
            try
            {
                return Core.Context.Subjects.Where(x => !x.IsActual).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetSubjects()
        {
            try
            {
                return Core.Context.Subjects.Where(x => x.IsActual).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RecoverSubject(object item)
        {
            try
            {
                var subject = Core.Context.Subjects.Find((item as Subject).IdSubject);
                subject.IsActual = true;
                Core.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
