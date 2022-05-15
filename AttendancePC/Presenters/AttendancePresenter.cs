using AttendancePC.Models;
using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using AttendancePC.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Presenters
{
    class AttendancePresenter
    {
        private readonly IAttendanceView view;
        private readonly IAttendanceModel model;

        public AttendancePresenter(IAttendanceView view)
        {
            this.view = view;
            model = new AttendanceModel();
            Global.DataChanged += Global_DataChanged;
        }
        private void Global_DataChanged()
        {
            LoadAttends(Global.CurrentDate);
        }

        public void SetCurrentDate(DateTime date)
        {
            Global.CurrentDate = date;
        }

        public void IncrementCurrentDate(int increment)
        {
            view.Date = view.Date.AddDays(increment);
        }

        public void HandleCell(bool IsEdit, MouseButtons button, object bindeedObject)
        {
            if (IsEdit)
            {
                if (button == MouseButtons.Left)
                {
                    SetAttendChar(bindeedObject as AttendRepresentation);
                }
                else if (button == MouseButtons.Right)
                {
                    SetReasonable(bindeedObject as AttendRepresentation);
                }
            }
        }

        public void LoadAttends(DateTime date)
        {
            try
            {
                view.Data = model.LoadAttends(date, view.Filter as Student, (int)view.Order);
                view.Headers = model.GetDayPairs(date).ToArray();
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }

        }

        public void LoadStudents()
        {
            try
            {
                view.Students = model.LoadStudents();
                view.Order = new List<string> { "Без сортировки", "По возрастанию", "По убыванию" };
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }

        public void SetStyle(DataGridViewRowCollection rowCollection)
        {
            foreach (DataGridViewRow row in rowCollection)
            {
                for (int i = 1; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[i];
                    var item = cell.Value as AttendRepresentation;
                    cell.Style.BackColor = item.IsReasonable ?? false ? Color.Green : Color.White;
                    cell.Style.BackColor = !(item.IsReasonable ?? true)
                        && (item.AttendChar == "-" || item.AttendChar == "/") ? Color.LightPink : cell.Style.BackColor;
                }
            }
        }

        public void SetAttendChar(AttendRepresentation item)
        {
            try
            {
                model.SetAttendChar(item);
                LoadAttends(Global.CurrentDate);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
        public void SetReasonable(AttendRepresentation item)
        {
            try
            {
                model.SetReasonable(item);
                LoadAttends(Global.CurrentDate);
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}
