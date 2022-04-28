using AttendancePC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Models
{
    public interface IStudentsModel
    {
        List<Student> GetStudents();
        List<Student> GetDismissedStudents();
        void AddStudent(string name);
        void DeleteStudent(object student);
        void RecoverStudent(object item);
    }
}
