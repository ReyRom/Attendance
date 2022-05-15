using AttendancePC.Models;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                view.SummaryAttendance = model.GetSummaryAttendance(startDate, endDate);
                view.SumAttendance = model.Summary(startDate, endDate);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
            
        }
        public void SaveSummaryAttendance(DateTime startDate, DateTime endDate, string filename)
        {
            try
            {
                model.SaveSummaryAttendance( filename, model.GetSummaryAttendance(startDate, endDate), model.Summary(startDate, endDate));
                UserFeedback.InformationMessage("Отчет успешно сохранен");
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
            
        }

        internal void GetSummarySubjects(DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = model.GetSummarySubjects(startDate, endDate);
                view.DiagramSource = data;
                view.SummarySubjects = data;
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        internal void SaveSummarySubjects(DateTime startDate, DateTime endDate, string filename)
        {
            try
            {
                var image = Environment.CurrentDirectory + @"\image.png";
                view.Diagram.SaveImage(image, System.Drawing.Imaging.ImageFormat.Png);
                model.SaveSummarySubjects(filename, startDate, endDate, image);
                UserFeedback.InformationMessage("Отчет успешно сохранен");
                File.Delete(image);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}
