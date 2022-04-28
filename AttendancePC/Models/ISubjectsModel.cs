using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    internal interface ISubjectsModel
    {
        object GetNonActualSubjects();
        object GetSubjects();
        void AddSubject(string name);
        void DeleteSubject(object item);
        void RecoverSubject(object item);
    }
}
