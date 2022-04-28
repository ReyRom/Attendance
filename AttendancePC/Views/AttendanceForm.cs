using AttendancePC.Models.Entities;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class AttendanceForm : Form, IAttendanceView
    {   
        Presenters.AttendancePresenter presenter;
        public event EventHandler<EventArgs> DataRenew;

        public object[] Headers
        {
            set
            {
                for (int i = 1; i <= 6; i++)
                {
                    AttendanceDataGridView.Columns[i].HeaderText = value[i - 1].ToString();
                }
            }
        }
        public object Data
        {
            set
            {
                AttendanceDataGridView.DataSource = value;
                DataRenew(this, EventArgs.Empty);
            }
        }

        public DateTime Date
        {
            set 
            { 
                LessonsDateTimePicker.Value = value; 
            }
            get
            {
                return LessonsDateTimePicker.Value;
            }
        }

        public object Students 
        {
            set 
            { 
                StudentToolStripComboBox.ComboBox.DataSource = value;
            }
        }

        public object Filter
        {
            get
            {
                return StudentToolStripComboBox.SelectedItem;
            }
        }

        public AttendanceForm()
        {
            InitializeComponent();            
            presenter = new Presenters.AttendancePresenter(this);
            DataRenew += AttendanceForm_DataRenew;

            StudentToolStripComboBox.ComboBox.DisplayMember = "Name";
        }

        private void AttendanceForm_DataRenew(object sender, EventArgs e)
        {
            presenter.SetStyle(AttendanceDataGridView.Rows);
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            presenter.LoadStudents();
            presenter.LoadAttends(Global.CurrentDate);
        }

        private void AttendanceDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != 0)
            {
                presenter.HandleCell(
                  EditToolStripButton.Checked,
                  e.Button,
                  AttendanceDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }
        private void LessonsDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetCurrentDate(LessonsDateTimePicker.Value.Date);
        }

        private void PreviousDayButton_Click(object sender, EventArgs e)
        {
            presenter.IncrementCurrentDate(-1);
        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            presenter.IncrementCurrentDate(1);
        }

        private void StudentToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.LoadAttends(Global.CurrentDate);
        }
    }
}
