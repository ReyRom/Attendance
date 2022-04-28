using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    public class SubjectsModel : ISubjectsModel
    {
        public void AddSubject(string name)
        {
            Core.Context.Subjects.Add(new Subject { Name = name, IsActual = true });
            Core.Context.SaveChanges();
        }

        public void DeleteSubject(object item)
        {
            Core.Context.Subjects.Remove(item as Subject);
            Core.Context.SaveChanges();
        }

        public object GetNonActualSubjects()
        {
            return Core.Context.Subjects.Where(x => !x.IsActual).ToList();
        }

        public object GetSubjects()
        {
            return Core.Context.Subjects.Where(x => x.IsActual).ToList();
        }

        public void RecoverSubject(object item)
        {
            var subject = Core.Context.Subjects.Find((item as Subject).IdSubject);
            subject.IsActual = true;
            Core.Context.SaveChanges();
        }
    }
}
