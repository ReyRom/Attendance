using AttendancePC.Presenters;
using AttendancePC.Supporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class ReportsForm : Form, IReportsView
    {
        ReportsPresenter presenter;
        public object SummaryAttendance
        {
            set
            {
                SummaryDataGridView.DataSource = value;
            }
        }
        public object SumAttendance
        {
            set
            {
                SumDataGridView.DataSource = value;
            }
        }
        public object SummarySubjects
        {
            set
            {
                SubjectsSummaryDataGridView.DataSource = value;
            }
        }

        public ReportsForm()
        {
            InitializeComponent();

            presenter = new ReportsPresenter(this);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Таблицы|*.xlsx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    presenter.SaveSummaryAttendance(StartDateTimePicker.Value, EndDateTimePicker.Value, saveFile.FileName);
                }
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            presenter.GetSummaryAttendance(StartDateTimePicker.Value, EndDateTimePicker.Value);
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            presenter.GetSummarySubjects(StartDateTimePicker.Value, EndDateTimePicker.Value);
        }
    }
}
