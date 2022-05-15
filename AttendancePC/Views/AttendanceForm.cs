using AttendancePC.Presenters;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class AttendanceForm : Form, IAttendanceView
    {
        AttendancePresenter presenter;
        public event EventHandler<EventArgs> DataRenew;

        #region Controls
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

        public object Order
        {
            set 
            {
                OrderToolStripComboBox.ComboBox.DataSource = value;
            }
            get
            {
                return OrderToolStripComboBox.SelectedIndex;
            }
        }
        #endregion

        public AttendanceForm()
        {
            InitializeComponent();
            presenter = new AttendancePresenter(this);
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
            EditToolStripButton.Visible = Global.CurrentUser.Editor != null;
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

        private void OrderToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.LoadAttends(Global.CurrentDate);
        }
    }
}
