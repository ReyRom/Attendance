using AttendancePC.Supporting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace AttendancePC.Models
{
    internal class ReportsModel : IReportsModel
    {
        public DataTable GetSummaryAttendance(DateTime startDate, DateTime endDate)
        {
            var connection = new SqlConnection((new SqlConnectionStringBuilder() { DataSource = "ROMA1NV1CTUS", UserID = "sa", Password = "1", InitialCatalog = "Attendance" }).ToString());
            connection.Open();
            SqlParameter startDateParameter = new SqlParameter("@startDate", $"{startDate:dd/MM/yyyy}");
            SqlParameter endDateParameter = new SqlParameter("@endDate", $"{endDate:dd/MM/yyyy}");
            SqlCommand command = new SqlCommand("EXEC dbo.MissingsByPeriod @startDate, @endDate;" +
                "EXEC SP_Dynamic_Pivot @TableSRC = 'dbo.PeriodAttendance'," +
                "@ColumnName = 'Date'," +
                "@Field = 'Missing'," +
                "@FieldRows = 'Name'," +
                "@FunctionType = 'SUM'," +
                "@OutputTable = 'dbo.SummaryMissings'", connection);
            command.Parameters.Add(startDateParameter);
            command.Parameters.Add(endDateParameter);
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM dbo.SummaryMissings ORDER BY name;", connection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        public void SaveSummaryAttendance(string filename, DataTable summary, DataTable sum)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = false;
            excelApp.SheetsInNewWorkbook = 1;
            var workbook = excelApp.Workbooks.Add();
            var sheet = workbook.Sheets[1];
            ExportToExcel(sum, sheet);
            ExportToExcel(summary, sheet, 4, 1);
            workbook.SaveAs(filename);
            excelApp.Quit();
        }

        public void ExportToExcel(DataTable dt, Excel.Worksheet sheet, int columnOffset = 0, int startColumnIgnore = 0)
        {
            int excelHeader = 1 + columnOffset;
            for (int i = 0 + startColumnIgnore; i < dt.Columns.Count; i++)
            {
                sheet.Cells[1, excelHeader] = dt.Columns[i].ColumnName;
                excelHeader++;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0 + startColumnIgnore; j < dt.Columns.Count; j++)
                {
                    sheet.Cells[i + 2, j + 1 - startColumnIgnore + columnOffset] = dt.Rows[i][j];
                }
            }
        }

        public DataTable Summary(DateTime startDate, DateTime endDate)
        {
            DataTable dt = Data.ToDataTable(Core.Context.AttendanceSumViews.ToList());
            return dt;
        }

        public object GetSummarySubjects(DateTime startDate, DateTime endDate)
        {
            var data = Core.Context.Subjects.ToList().Select(s => new
            {
                s.Name,
                Count = s.Lessons.Where(l => l.Day.Date > startDate && l.Day.Date < endDate).Count(),
                Missings = s.Lessons.Where(l => l.Day.Date > startDate && l.Day.Date < endDate).Sum(l=> l.LessonAttends.Sum(x=>x.AttendChar == "-" ? 2 : 1))
            }).ToList();
            return data.Where(x=>x.Count>0).ToList();
        }
    }
}
