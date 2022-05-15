namespace AttendancePC.Views
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ReportsTabControl = new System.Windows.Forms.TabControl();
            this.SummaryTabPage = new System.Windows.Forms.TabPage();
            this.SumDataGridView = new System.Windows.Forms.DataGridView();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.SaveSummaryButton = new System.Windows.Forms.Button();
            this.SummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.NameStudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectsTabPage = new System.Windows.Forms.TabPage();
            this.SaveSubjectsSumButton = new System.Windows.Forms.Button();
            this.SubjectsSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectMissingsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectsButton = new System.Windows.Forms.Button();
            this.SubjectsSumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportsTabControl.SuspendLayout();
            this.SummaryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGridView)).BeginInit();
            this.SubjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsSummaryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsSumChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsTabControl
            // 
            this.ReportsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportsTabControl.Controls.Add(this.SummaryTabPage);
            this.ReportsTabControl.Controls.Add(this.SubjectsTabPage);
            this.ReportsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportsTabControl.Location = new System.Drawing.Point(0, 38);
            this.ReportsTabControl.Name = "ReportsTabControl";
            this.ReportsTabControl.SelectedIndex = 0;
            this.ReportsTabControl.Size = new System.Drawing.Size(735, 302);
            this.ReportsTabControl.TabIndex = 1;
            // 
            // SummaryTabPage
            // 
            this.SummaryTabPage.Controls.Add(this.SumDataGridView);
            this.SummaryTabPage.Controls.Add(this.SummaryButton);
            this.SummaryTabPage.Controls.Add(this.SaveSummaryButton);
            this.SummaryTabPage.Controls.Add(this.SummaryDataGridView);
            this.SummaryTabPage.Location = new System.Drawing.Point(4, 29);
            this.SummaryTabPage.Name = "SummaryTabPage";
            this.SummaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryTabPage.Size = new System.Drawing.Size(727, 269);
            this.SummaryTabPage.TabIndex = 0;
            this.SummaryTabPage.Text = "Сводная посещаемость";
            this.SummaryTabPage.UseVisualStyleBackColor = true;
            // 
            // SumDataGridView
            // 
            this.SumDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SumDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SumDataGridView.Location = new System.Drawing.Point(3, 42);
            this.SumDataGridView.Name = "SumDataGridView";
            this.SumDataGridView.RowHeadersVisible = false;
            this.SumDataGridView.Size = new System.Drawing.Size(278, 224);
            this.SumDataGridView.TabIndex = 4;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaryButton.Location = new System.Drawing.Point(6, 3);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(203, 33);
            this.SummaryButton.TabIndex = 3;
            this.SummaryButton.Text = "Сформировать отчет";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // SaveSummaryButton
            // 
            this.SaveSummaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSummaryButton.Enabled = false;
            this.SaveSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSummaryButton.Location = new System.Drawing.Point(595, 6);
            this.SaveSummaryButton.Name = "SaveSummaryButton";
            this.SaveSummaryButton.Size = new System.Drawing.Size(126, 30);
            this.SaveSummaryButton.TabIndex = 2;
            this.SaveSummaryButton.Text = "Сохранить";
            this.SaveSummaryButton.UseVisualStyleBackColor = true;
            this.SaveSummaryButton.Click += new System.EventHandler(this.SaveSummaryButton_Click);
            // 
            // SummaryDataGridView
            // 
            this.SummaryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SummaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameStudentColumn});
            this.SummaryDataGridView.Location = new System.Drawing.Point(287, 42);
            this.SummaryDataGridView.Name = "SummaryDataGridView";
            this.SummaryDataGridView.RowHeadersVisible = false;
            this.SummaryDataGridView.Size = new System.Drawing.Size(437, 224);
            this.SummaryDataGridView.TabIndex = 0;
            // 
            // NameStudentColumn
            // 
            this.NameStudentColumn.DataPropertyName = "Name";
            this.NameStudentColumn.HeaderText = "ФИО";
            this.NameStudentColumn.Name = "NameStudentColumn";
            this.NameStudentColumn.Width = 72;
            // 
            // SubjectsTabPage
            // 
            this.SubjectsTabPage.Controls.Add(this.SaveSubjectsSumButton);
            this.SubjectsTabPage.Controls.Add(this.SubjectsSummaryDataGridView);
            this.SubjectsTabPage.Controls.Add(this.SubjectsButton);
            this.SubjectsTabPage.Controls.Add(this.SubjectsSumChart);
            this.SubjectsTabPage.Location = new System.Drawing.Point(4, 29);
            this.SubjectsTabPage.Name = "SubjectsTabPage";
            this.SubjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectsTabPage.Size = new System.Drawing.Size(727, 269);
            this.SubjectsTabPage.TabIndex = 1;
            this.SubjectsTabPage.Text = "Предметы";
            this.SubjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveSubjectsSumButton
            // 
            this.SaveSubjectsSumButton.Enabled = false;
            this.SaveSubjectsSumButton.Location = new System.Drawing.Point(200, 3);
            this.SaveSubjectsSumButton.Name = "SaveSubjectsSumButton";
            this.SaveSubjectsSumButton.Size = new System.Drawing.Size(103, 36);
            this.SaveSubjectsSumButton.TabIndex = 6;
            this.SaveSubjectsSumButton.Text = "Сохранить";
            this.SaveSubjectsSumButton.UseVisualStyleBackColor = true;
            this.SaveSubjectsSumButton.Click += new System.EventHandler(this.SaveSubjectsSumButton_Click);
            // 
            // SubjectsSummaryDataGridView
            // 
            this.SubjectsSummaryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectsSummaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectsSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsSummaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectColumn,
            this.CountColumn,
            this.SubjectMissingsColumn});
            this.SubjectsSummaryDataGridView.Location = new System.Drawing.Point(8, 45);
            this.SubjectsSummaryDataGridView.Name = "SubjectsSummaryDataGridView";
            this.SubjectsSummaryDataGridView.RowHeadersVisible = false;
            this.SubjectsSummaryDataGridView.Size = new System.Drawing.Size(298, 224);
            this.SubjectsSummaryDataGridView.TabIndex = 5;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.DataPropertyName = "Name";
            this.SubjectColumn.HeaderText = "Предмет";
            this.SubjectColumn.Name = "SubjectColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.DataPropertyName = "Count";
            this.CountColumn.HeaderText = "Кол-во пар";
            this.CountColumn.Name = "CountColumn";
            // 
            // SubjectMissingsColumn
            // 
            this.SubjectMissingsColumn.DataPropertyName = "Missings";
            this.SubjectMissingsColumn.HeaderText = "Пропуски";
            this.SubjectMissingsColumn.Name = "SubjectMissingsColumn";
            // 
            // SubjectsButton
            // 
            this.SubjectsButton.Location = new System.Drawing.Point(6, 3);
            this.SubjectsButton.Name = "SubjectsButton";
            this.SubjectsButton.Size = new System.Drawing.Size(188, 36);
            this.SubjectsButton.TabIndex = 4;
            this.SubjectsButton.Text = "Сформировать отчет";
            this.SubjectsButton.UseVisualStyleBackColor = true;
            this.SubjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // SubjectsSumChart
            // 
            this.SubjectsSumChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.Name = "ChartArea1";
            this.SubjectsSumChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SubjectsSumChart.Legends.Add(legend2);
            this.SubjectsSumChart.Location = new System.Drawing.Point(312, 6);
            this.SubjectsSumChart.Name = "SubjectsSumChart";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SubjectsSumChart.Series.Add(series2);
            this.SubjectsSumChart.Size = new System.Drawing.Size(407, 272);
            this.SubjectsSumChart.TabIndex = 0;
            this.SubjectsSumChart.Text = "chart1";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(190, 6);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(172, 26);
            this.StartDateTimePicker.TabIndex = 1;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(403, 6);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(172, 26);
            this.EndDateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отчетный период: от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(368, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "до";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.ReportsTabControl);
            this.Controls.Add(this.StartDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(751, 379);
            this.Name = "ReportsForm";
            this.Text = "Отчеты";
            this.ReportsTabControl.ResumeLayout(false);
            this.SummaryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGridView)).EndInit();
            this.SubjectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsSummaryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsSumChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl ReportsTabControl;
        private System.Windows.Forms.TabPage SummaryTabPage;
        private System.Windows.Forms.TabPage SubjectsTabPage;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DataGridView SummaryDataGridView;
        private System.Windows.Forms.Button SaveSummaryButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.DataGridView SumDataGridView;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button SubjectsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart SubjectsSumChart;
        private System.Windows.Forms.DataGridView SubjectsSummaryDataGridView;
        private System.Windows.Forms.Button SaveSubjectsSumButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectMissingsColumn;
    }
}