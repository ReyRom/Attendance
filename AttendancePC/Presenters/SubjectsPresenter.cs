using AttendancePC.Models;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Presenters
{
    public class SubjectsPresenter
    {
        ISubjectsModel model;
        ISubjectsView view;

        public SubjectsPresenter(ISubjectsView view)
        {
            this.model = new SubjectsModel();
            this.view = view;
        }

        public void LoadData()
        {
            view.Subjects = model.GetSubjects();
            view.NonActual = model.GetNonActualSubjects();
        }

        public void AddSubject(string name)
        {
            if (String.IsNullOrWhiteSpace(name)) return;
            model.AddSubject(name);
            LoadData();
        }

        public void DeactualizeSubject(object item)
        {
            if (item == null) return;
            model.DeleteSubject(item);
            LoadData();
        }

        public void DeleteSubject(object item)
        {
            if (item == null) return;
            model.DeleteSubject(item);
            LoadData();
        }

        internal void RecoverSubject(object item)
        {
            if (item == null) return;
            model.RecoverSubject(item);
            LoadData();
        }
    }
}
