using AttendancePC.Models;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;

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
            try
            {
                view.Subjects = model.GetSubjects();
                view.NonActual = model.GetNonActualSubjects();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void AddSubject(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name)) return;
                model.AddSubject(name);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void DeactualizeSubject(object item)
        {
            try
            {
                if (item == null) return;
                model.DeleteSubject(item);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void DeleteSubject(object item)
        {
            try
            {
                if (item == null) return;
                model.DeleteSubject(item);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        internal void RecoverSubject(object item)
        {
            try
            {
                if (item == null) return;
                model.RecoverSubject(item);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}
