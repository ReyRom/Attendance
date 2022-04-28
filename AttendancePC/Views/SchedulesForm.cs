using AttendancePC.Models;
using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class ShedulesForm : Form, ISchedulesView
    {
        Presenters.SchedulesPresenter presenter;

        public object Schedules 
        { 
            set
            {
                ScheduleComboBox.DataSource = value;
                ScheduleComboBox.DisplayMember = "Name";
            } 
        }
        public object Schedule 
        { 
            set 
            {
                SheduleDataGridView.DataSource = value;
            } 
        }
        public object DaysOfWeek 
        { 
            set 
            {
                ScheduleDayComboBox.DataSource = value;
            } 
        }

        public object Subjects
        {
            set
            {
                PairColumn.DataSource = value;
                PairColumn.DisplayMember = "Name";
                PairColumn.ValueMember = "IdSubject";
            }
        }
        public ShedulesForm()
        {
            InitializeComponent();

            presenter = new Presenters.SchedulesPresenter(this);
        }

        private void ShedulesForm_Load(object sender, EventArgs e)
        {
            presenter.GetShedules();
            presenter.GetDaysOfWeek();
            presenter.GetSubjects();

            presenter.LoadShedule(Global.CurrentDate);
        }

        private void ConfirmSheduleButton_Click(object sender, EventArgs e)
        {
            presenter.LoadShedule((ScheduleComboBox.SelectedItem as ScheduleRepresentation).Lessons);
        }

        private void SaveSheduleTemplateButton_Click(object sender, EventArgs e)
        {
            presenter.SaveScheduleTemplate(SheduleDataGridView.DataSource as List<LessonRepresentation>, (byte)(ScheduleDayComboBox.SelectedIndex + 1), IsEvenCheckBox.Checked);
        }

        private void SaveSheduleButton_Click(object sender, EventArgs e)
        {
            presenter.SaveSchedule(SheduleDataGridView.DataSource as List<LessonRepresentation>);
        }
    }
}
