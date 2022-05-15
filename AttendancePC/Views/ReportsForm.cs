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
using System.Windows.Forms.DataVisualization.Charting;

namespace AttendancePC.Views
{
    public partial class ReportsForm : Form, IReportsView
    {
        ReportsPresenter presenter;

        #region Controls
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

        public object[] DiagramSource
        {
            set
            {
                SubjectsSumChart.Series[0].Points.Clear();
                foreach (dynamic item in value)
                {
                    SubjectsSumChart.Series[0].Points.AddXY(item.Name, item.Missings*1.0/item.Attends*100);
                }
                
            }
        }
        public Chart Diagram
        {
            get
            {
                return SubjectsSumChart;
            }
        }
        #endregion

        public ReportsForm()
        {
            InitializeComponent();

            presenter = new ReportsPresenter(this);
        }

        private void SaveSummaryButton_Click(object sender, EventArgs e)
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

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            presenter.GetSummaryAttendance(StartDateTimePicker.Value, EndDateTimePicker.Value);
            SaveSummaryButton.Enabled = true;
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            presenter.GetSummarySubjects(StartDateTimePicker.Value, EndDateTimePicker.Value);
            SaveSubjectsSumButton.Enabled = true;
        }

        private void SaveSubjectsSumButton_Click(object sender, EventArgs e)
        {
            using (var saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Текстовые документы|*.docx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    presenter.SaveSummarySubjects(StartDateTimePicker.Value, EndDateTimePicker.Value, saveFile.FileName);
                }
            }
        }
    }
}
