using AttendancePC.Models;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Presenters
{
    public class StudentsPresenter
    {
        IStudentsModel model;
        IStudentsView view;

        public StudentsPresenter(IStudentsView view)
        {
            this.model = new StudentsModel();
            this.view = view;
        }

        public void LoadData()
        {
            view.Students = model.GetStudents();
            view.Dismissed = model.GetDismissedStudents();
        }

        public void AddStudent(string name)
        {
            model.AddStudent(name);
            LoadData();
        }

        public void RecoverStudent(object item)
        {
            model.RecoverStudent(item);
            LoadData();
        }

        public void DeleteStudent(object item)
        {
            model.DeleteStudent(item);
            LoadData();
        }
    }
}
