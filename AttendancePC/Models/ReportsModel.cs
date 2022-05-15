using AttendancePC.Supporting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace AttendancePC.Models
{
    internal class ReportsModel : IReportsModel
    {
        DataTable summaryAttendance;
        DataTable summary;

        public DataTable GetSummaryAttendance(DateTime startDate, DateTime endDate)
        {
            try
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
                command.ExecuteNonQuery();
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM dbo.SummaryMissings ORDER BY name;", connection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                summaryAttendance = new DataTable();
                summaryAttendance.Load(reader);
                connection.Close();
                return summaryAttendance;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveSummaryAttendance(string filename, DataTable summary, DataTable sum)
        {
            try
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.SheetsInNewWorkbook = 1;
                var workbook = excelApp.Workbooks.Add();
                var sheet = workbook.Worksheets[1];
                ExportToExcel(sum, sheet);
                ExportToExcel(summary, sheet, 4, 1);
                workbook.SaveAs(filename);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                summary = Data.ToDataTable(Core.Context.AttendanceSumViews.ToList());
                summary.Columns[0].ColumnName = "ФИО";
                summary.Columns[1].ColumnName = "НБ";
                summary.Columns[2].ColumnName = "У";
                summary.Columns[3].ColumnName = "БУ";
                return summary;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object[] GetSummarySubjects(DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = Core.Context.Subjects.ToList().Select(s => new
                {
                    s.Name,
                    Count = s.Lessons.Where(l => l.Day.Date > startDate && l.Day.Date < endDate).Count(),
                    Missings = s.Lessons.Where(l => l.Day.Date > startDate && l.Day.Date < endDate).Sum(l => l.LessonAttends
                    .Where(x => !x.Student.IsDismissed).Sum(x => x.AttendChar == "-" ? 2 : 1)),
                    Attends = s.Lessons.Where(l => l.Day.Date > startDate && l.Day.Date < endDate).Count() * Core.Context.Students.Count(x => !x.IsDismissed),
                }).ToList();
                return data.Where(x => x.Count > 0).ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveSummarySubjects(string filename, DateTime startDate, DateTime endDate, string image)
        {
            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var document = wordApp.Documents.Add(Environment.CurrentDirectory + @"\Templates\template.docx");
                document.Content.Find.Execute(FindText: "%startDate%", ReplaceWith: startDate.ToShortDateString());
                document.Content.Find.Execute(FindText: "%endDate%", ReplaceWith: endDate.ToShortDateString());
                var range = document.Range();
                range.Find.Execute(FindText: "%diagram%", ReplaceWith: "");
                Word.InlineShape shape = range.InlineShapes.AddPicture(image);
                var table = document.Tables[1];

                var data = GetSummarySubjects(startDate, endDate);
                for (int i = 0; i < data.Length; i++)
                {
                    dynamic item = data[i];
                    table.Rows.Add(table.Rows[i + 2]);
                    table.Cell(i + 2, 1).Range.Text = item.Name;
                    table.Cell(i + 2, 2).Range.Text = $"{item.Count}";
                    table.Cell(i + 2, 3).Range.Text = $"{item.Missings}";
                }
                table.Rows.Last.Delete();

                document.SaveAs(filename);
                wordApp.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
