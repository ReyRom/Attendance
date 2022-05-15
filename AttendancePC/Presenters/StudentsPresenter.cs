using AttendancePC.Models;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;

namespace AttendancePC.Presenters
{
    public class StudentsPresenter : IPresenter
    {
        IStudentsModel model;
        IStudentsView view;

        public event EventHandler<EventArgs> RenewEvent;

        public StudentsPresenter(IStudentsView view)
        {
            this.model = new StudentsModel();
            this.view = view;

            Global.InitializePresenter(this);
        }

        public void LoadData()
        {
            try
            {
                view.Students = model.GetStudents();
                view.Dismissed = model.GetDismissedStudents();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }

        }

        public void AddStudent(string name)
        {
            try
            {
                model.AddStudent(name);
                RenewEvent?.Invoke(this, EventArgs.Empty);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }

        }

        public void RecoverStudent(object item)
        {
            try
            {
                model.RecoverStudent(item);
                RenewEvent?.Invoke(this, EventArgs.Empty);
                LoadData();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }

        }

        public void DeleteStudent(object item)
        {
            try
            {
                model.DeleteStudent(item);
                RenewEvent?.Invoke(this, EventArgs.Empty);
                LoadData();
            }
            catch (Exception ex) 
            { 
                UserFeedback.ErrorMessage(ex); 
            }
        }
    }
}
