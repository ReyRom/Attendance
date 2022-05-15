using AttendancePC.Models;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;
using System.Collections.Generic;

namespace AttendancePC.Presenters
{
    public class SchedulesPresenter : IPresenter
    {
        ISchedulesView view;
        ISchedulesModel model;

        public event EventHandler<EventArgs> RenewEvent;

        public SchedulesPresenter(ISchedulesView view)
        {
            this.view = view;
            model = new SchedulesModel();

            Global.InitializePresenter(this);
            Global.DataChanged += Global_DataChanged;
        }

        private void Global_DataChanged()
        {
            try
            {
                LoadShedule(Global.CurrentDate);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void LoadShedule(DateTime date)
        {
            try
            {
                view.Schedule = model.LoadShedule(date);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void LoadShedule(List<LessonRepresentation> data)
        {
            try
            {
                view.Schedule = model.LoadShedule(data);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
        public void GetDaysOfWeek()
        {
            try
            {
                view.DaysOfWeek = model.GetDaysOfWeek();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void GetShedules()
        {
            try
            {
                view.Schedules = model.GetShedules();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void GetSubjects()
        {
            try
            {
                view.Subjects = model.GetSubjects();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void SaveScheduleTemplate(List<LessonRepresentation> lessons, byte dayOfWeek, bool isEven)
        {
            try
            {
                model.SaveScheduleTemplate(lessons, dayOfWeek, isEven);
                GetShedules();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void SaveSchedule(List<LessonRepresentation> lessons)
        {
            try
            {
                model.SaveSchedule(lessons);
                RenewEvent?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}
