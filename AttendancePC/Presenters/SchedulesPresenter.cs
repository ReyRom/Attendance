using AttendancePC.Models;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Presenters
{
    public class SchedulesPresenter: IPresenter
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
            LoadShedule(Global.CurrentDate);
        }

        public void LoadShedule(DateTime date)
        {
            view.Schedule = model.LoadShedule(date);
        }
        public void LoadShedule(List<LessonRepresentation> data)
        {
            view.Schedule = model.LoadShedule(data);
        }
        public void GetDaysOfWeek()
        {
            view.DaysOfWeek = model.GetDaysOfWeek();
        }
        public void GetShedules()
        {
            view.Schedules = model.GetShedules();
        }
        public void GetSubjects() 
        {
            view.Subjects = model.GetSubjects();
        }

        public void SaveScheduleTemplate(List<LessonRepresentation> lessons, byte dayOfWeek, bool isEven)
        { 
            model.SaveScheduleTemplate(lessons, dayOfWeek, isEven);
            GetShedules();
        }
        public void SaveSchedule(List<LessonRepresentation> lessons)
        {
            model.SaveSchedule(lessons);
            RenewEvent?.Invoke(this, new EventArgs());
        }
    }
}
