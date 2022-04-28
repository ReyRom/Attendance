namespace AttendancePC.Views
{
    partial class ShedulesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveSheduleTemplateButton = new System.Windows.Forms.Button();
            this.IsEvenCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveSheduleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleDayComboBox = new System.Windows.Forms.ComboBox();
            this.SheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.PairNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PairColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmSheduleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveSheduleTemplateButton
            // 
            this.SaveSheduleTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSheduleTemplateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSheduleTemplateButton.Location = new System.Drawing.Point(243, 420);
            this.SaveSheduleTemplateButton.Name = "SaveSheduleTemplateButton";
            this.SaveSheduleTemplateButton.Size = new System.Drawing.Size(150, 28);
            this.SaveSheduleTemplateButton.TabIndex = 25;
            this.SaveSheduleTemplateButton.Text = "Сохранить";
            this.SaveSheduleTemplateButton.UseVisualStyleBackColor = true;
            this.SaveSheduleTemplateButton.Click += new System.EventHandler(this.SaveSheduleTemplateButton_Click);
            // 
            // IsEvenCheckBox
            // 
            this.IsEvenCheckBox.AutoSize = true;
            this.IsEvenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsEvenCheckBox.Location = new System.Drawing.Point(14, 454);
            this.IsEvenCheckBox.Name = "IsEvenCheckBox";
            this.IsEvenCheckBox.Size = new System.Drawing.Size(85, 24);
            this.IsEvenCheckBox.TabIndex = 28;
            this.IsEvenCheckBox.Text = "Четная";
            this.IsEvenCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveSheduleButton
            // 
            this.SaveSheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSheduleButton.Location = new System.Drawing.Point(210, 271);
            this.SaveSheduleButton.Name = "SaveSheduleButton";
            this.SaveSheduleButton.Size = new System.Drawing.Size(183, 31);
            this.SaveSheduleButton.TabIndex = 21;
            this.SaveSheduleButton.Text = "Сохранить";
            this.SaveSheduleButton.UseVisualStyleBackColor = true;
            this.SaveSheduleButton.Click += new System.EventHandler(this.SaveSheduleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Сохранить как шаблон";
            // 
            // ScheduleDayComboBox
            // 
            this.ScheduleDayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleDayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleDayComboBox.FormattingEnabled = true;
            this.ScheduleDayComboBox.Location = new System.Drawing.Point(11, 420);
            this.ScheduleDayComboBox.Name = "ScheduleDayComboBox";
            this.ScheduleDayComboBox.Size = new System.Drawing.Size(219, 28);
            this.ScheduleDayComboBox.TabIndex = 27;
            // 
            // SheduleDataGridView
            // 
            this.SheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SheduleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SheduleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PairNumberColumn,
            this.PairColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SheduleDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SheduleDataGridView.Location = new System.Drawing.Point(11, 28);
            this.SheduleDataGridView.MultiSelect = false;
            this.SheduleDataGridView.Name = "SheduleDataGridView";
            this.SheduleDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SheduleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SheduleDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SheduleDataGridView.RowTemplate.DividerHeight = 1;
            this.SheduleDataGridView.RowTemplate.Height = 30;
            this.SheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SheduleDataGridView.Size = new System.Drawing.Size(382, 237);
            this.SheduleDataGridView.TabIndex = 23;
            // 
            // PairNumberColumn
            // 
            this.PairNumberColumn.DataPropertyName = "OrderNumber";
            this.PairNumberColumn.FillWeight = 40.60914F;
            this.PairNumberColumn.HeaderText = "№";
            this.PairNumberColumn.Name = "PairNumberColumn";
            // 
            // PairColumn
            // 
            this.PairColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PairColumn.DataPropertyName = "IdSubject";
            this.PairColumn.FillWeight = 159.3909F;
            this.PairColumn.HeaderText = "Пара";
            this.PairColumn.Name = "PairColumn";
            this.PairColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PairColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ScheduleComboBox
            // 
            this.ScheduleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleComboBox.FormattingEnabled = true;
            this.ScheduleComboBox.Location = new System.Drawing.Point(11, 354);
            this.ScheduleComboBox.Name = "ScheduleComboBox";
            this.ScheduleComboBox.Size = new System.Drawing.Size(219, 28);
            this.ScheduleComboBox.TabIndex = 20;
            // 
            // ConfirmSheduleButton
            // 
            this.ConfirmSheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmSheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmSheduleButton.Location = new System.Drawing.Point(243, 354);
            this.ConfirmSheduleButton.Name = "ConfirmSheduleButton";
            this.ConfirmSheduleButton.Size = new System.Drawing.Size(150, 28);
            this.ConfirmSheduleButton.TabIndex = 22;
            this.ConfirmSheduleButton.Text = "Применить";
            this.ConfirmSheduleButton.UseVisualStyleBackColor = true;
            this.ConfirmSheduleButton.Click += new System.EventHandler(this.ConfirmSheduleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Шаблон";
            // 
            // ShedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 507);
            this.Controls.Add(this.SaveSheduleTemplateButton);
            this.Controls.Add(this.IsEvenCheckBox);
            this.Controls.Add(this.SaveSheduleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScheduleDayComboBox);
            this.Controls.Add(this.SheduleDataGridView);
            this.Controls.Add(this.ScheduleComboBox);
            this.Controls.Add(this.ConfirmSheduleButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShedulesForm";
            this.Text = "SchedulesForm";
            this.Load += new System.EventHandler(this.ShedulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveSheduleTemplateButton;
        private System.Windows.Forms.CheckBox IsEvenCheckBox;
        private System.Windows.Forms.Button SaveSheduleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ScheduleDayComboBox;
        private System.Windows.Forms.DataGridView SheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PairNumberColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn PairColumn;
        private System.Windows.Forms.ComboBox ScheduleComboBox;
        private System.Windows.Forms.Button ConfirmSheduleButton;
        private System.Windows.Forms.Label label1;
    }
}