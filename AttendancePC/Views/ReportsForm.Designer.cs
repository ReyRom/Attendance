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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ReportsTabControl = new System.Windows.Forms.TabControl();
            this.SummaryTabPage = new System.Windows.Forms.TabPage();
            this.SumDataGridView = new System.Windows.Forms.DataGridView();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectsTabPage = new System.Windows.Forms.TabPage();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SubjectsButton = new System.Windows.Forms.Button();
            this.SubjectsSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.ReportsTabControl.SuspendLayout();
            this.SummaryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGridView)).BeginInit();
            this.SubjectsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsSummaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsTabControl
            // 
            this.ReportsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportsTabControl.Controls.Add(this.SummaryTabPage);
            this.ReportsTabControl.Controls.Add(this.SubjectsTabPage);
            this.ReportsTabControl.Location = new System.Drawing.Point(0, 40);
            this.ReportsTabControl.Name = "ReportsTabControl";
            this.ReportsTabControl.SelectedIndex = 0;
            this.ReportsTabControl.Size = new System.Drawing.Size(732, 436);
            this.ReportsTabControl.TabIndex = 1;
            // 
            // SummaryTabPage
            // 
            this.SummaryTabPage.Controls.Add(this.SumDataGridView);
            this.SummaryTabPage.Controls.Add(this.SummaryButton);
            this.SummaryTabPage.Controls.Add(this.SaveButton);
            this.SummaryTabPage.Controls.Add(this.SummaryDataGridView);
            this.SummaryTabPage.Location = new System.Drawing.Point(4, 22);
            this.SummaryTabPage.Name = "SummaryTabPage";
            this.SummaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryTabPage.Size = new System.Drawing.Size(724, 410);
            this.SummaryTabPage.TabIndex = 0;
            this.SummaryTabPage.Text = "Сводная посещаемость";
            this.SummaryTabPage.UseVisualStyleBackColor = true;
            // 
            // SumDataGridView
            // 
            this.SumDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SumDataGridView.Location = new System.Drawing.Point(3, 32);
            this.SumDataGridView.Name = "SumDataGridView";
            this.SumDataGridView.RowHeadersVisible = false;
            this.SumDataGridView.Size = new System.Drawing.Size(182, 375);
            this.SumDataGridView.TabIndex = 4;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(6, 3);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(126, 23);
            this.SummaryButton.TabIndex = 3;
            this.SummaryButton.Text = "Сформировать отчет";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(618, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SummaryDataGridView
            // 
            this.SummaryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SummaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryDataGridView.Location = new System.Drawing.Point(191, 32);
            this.SummaryDataGridView.Name = "SummaryDataGridView";
            this.SummaryDataGridView.RowHeadersVisible = false;
            this.SummaryDataGridView.Size = new System.Drawing.Size(530, 375);
            this.SummaryDataGridView.TabIndex = 0;
            // 
            // SubjectsTabPage
            // 
            this.SubjectsTabPage.Controls.Add(this.SubjectsSummaryDataGridView);
            this.SubjectsTabPage.Controls.Add(this.SubjectsButton);
            this.SubjectsTabPage.Controls.Add(this.chart1);
            this.SubjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SubjectsTabPage.Name = "SubjectsTabPage";
            this.SubjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectsTabPage.Size = new System.Drawing.Size(724, 410);
            this.SubjectsTabPage.TabIndex = 1;
            this.SubjectsTabPage.Text = "Предметы";
            this.SubjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(10, 12);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.StartDateTimePicker.TabIndex = 1;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(151, 12);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.EndDateTimePicker.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(309, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(407, 396);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // SubjectsButton
            // 
            this.SubjectsButton.Location = new System.Drawing.Point(6, 3);
            this.SubjectsButton.Name = "SubjectsButton";
            this.SubjectsButton.Size = new System.Drawing.Size(126, 23);
            this.SubjectsButton.TabIndex = 4;
            this.SubjectsButton.Text = "Сформировать отчет";
            this.SubjectsButton.UseVisualStyleBackColor = true;
            this.SubjectsButton.Click += new System.EventHandler(this.SubjectsButton_Click);
            // 
            // SubjectsSummaryDataGridView
            // 
            this.SubjectsSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsSummaryDataGridView.Location = new System.Drawing.Point(8, 32);
            this.SubjectsSummaryDataGridView.Name = "SubjectsSummaryDataGridView";
            this.SubjectsSummaryDataGridView.Size = new System.Drawing.Size(295, 370);
            this.SubjectsSummaryDataGridView.TabIndex = 5;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 476);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.ReportsTabControl);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.ReportsTabControl.ResumeLayout(false);
            this.SummaryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGridView)).EndInit();
            this.SubjectsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsSummaryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ReportsTabControl;
        private System.Windows.Forms.TabPage SummaryTabPage;
        private System.Windows.Forms.TabPage SubjectsTabPage;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DataGridView SummaryDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.DataGridView SumDataGridView;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button SubjectsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView SubjectsSummaryDataGridView;
    }
}