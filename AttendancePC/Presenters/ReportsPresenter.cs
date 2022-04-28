using AttendancePC.Models;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Presenters
{
    internal class ReportsPresenter
    {
        IReportsView view;
        IReportsModel model;

        public ReportsPresenter(IReportsView view)
        {
            this.view = view;
            model = new ReportsModel();
        }
        public void GetSummaryAttendance(DateTime startDate, DateTime endDate)
        {
            view.SummaryAttendance = model.GetSummaryAttendance(startDate, endDate);
            view.SumAttendance = model.Summary(startDate, endDate);
        }
        public void SaveSummaryAttendance(DateTime startDate, DateTime endDate, string filename)
        {
            model.SaveSummaryAttendance( filename, model.GetSummaryAttendance(startDate, endDate), model.Summary(startDate, endDate));
        }

        internal void GetSummarySubjects(DateTime startDate, DateTime endDate)
        {
            view.SummarySubjects = model.GetSummarySubjects(startDate, endDate);
        }
    }
}
