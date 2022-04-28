namespace AttendancePC.Views
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.PreviousDayButton = new System.Windows.Forms.Button();
            this.LessonsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AttendanceDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pair1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pair2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pair3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pair4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pair5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pair6Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextDayButton = new System.Windows.Forms.Button();
            this.AttendanceToolStrip = new System.Windows.Forms.ToolStrip();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StudentToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGridView)).BeginInit();
            this.AttendanceToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousDayButton
            // 
            this.PreviousDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousDayButton.Location = new System.Drawing.Point(108, 27);
            this.PreviousDayButton.MinimumSize = new System.Drawing.Size(35, 25);
            this.PreviousDayButton.Name = "PreviousDayButton";
            this.PreviousDayButton.Size = new System.Drawing.Size(35, 25);
            this.PreviousDayButton.TabIndex = 1;
            this.PreviousDayButton.Text = "<";
            this.PreviousDayButton.UseVisualStyleBackColor = true;
            this.PreviousDayButton.Click += new System.EventHandler(this.PreviousDayButton_Click);
            // 
            // LessonsDateTimePicker
            // 
            this.LessonsDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LessonsDateTimePicker.Location = new System.Drawing.Point(149, 27);
            this.LessonsDateTimePicker.MinimumSize = new System.Drawing.Size(120, 25);
            this.LessonsDateTimePicker.Name = "LessonsDateTimePicker";
            this.LessonsDateTimePicker.Size = new System.Drawing.Size(120, 25);
            this.LessonsDateTimePicker.TabIndex = 2;
            this.LessonsDateTimePicker.ValueChanged += new System.EventHandler(this.LessonsDateTimePicker_ValueChanged);
            // 
            // AttendanceDataGridView
            // 
            this.AttendanceDataGridView.AllowUserToAddRows = false;
            this.AttendanceDataGridView.AllowUserToDeleteRows = false;
            this.AttendanceDataGridView.AllowUserToResizeColumns = false;
            this.AttendanceDataGridView.AllowUserToResizeRows = false;
            this.AttendanceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendanceDataGridView.ColumnHeadersHeight = 40;
            this.AttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentColumn,
            this.Pair1Column,
            this.Pair2Column,
            this.Pair3Column,
            this.Pair4Column,
            this.Pair5Column,
            this.Pair6Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AttendanceDataGridView.Location = new System.Drawing.Point(12, 58);
            this.AttendanceDataGridView.MultiSelect = false;
            this.AttendanceDataGridView.Name = "AttendanceDataGridView";
            this.AttendanceDataGridView.ReadOnly = true;
            this.AttendanceDataGridView.RowHeadersVisible = false;
            this.AttendanceDataGridView.RowTemplate.Height = 25;
            this.AttendanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AttendanceDataGridView.ShowCellToolTips = false;
            this.AttendanceDataGridView.Size = new System.Drawing.Size(408, 705);
            this.AttendanceDataGridView.TabIndex = 4;
            this.AttendanceDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AttendanceDataGridView_CellMouseClick);
            // 
            // StudentColumn
            // 
            this.StudentColumn.DataPropertyName = "Name";
            this.StudentColumn.FillWeight = 90F;
            this.StudentColumn.HeaderText = "ФИО";
            this.StudentColumn.Name = "StudentColumn";
            this.StudentColumn.ReadOnly = true;
            // 
            // Pair1Column
            // 
            this.Pair1Column.DataPropertyName = "Pair1";
            this.Pair1Column.FillWeight = 30F;
            this.Pair1Column.HeaderText = "1 Пара";
            this.Pair1Column.Name = "Pair1Column";
            this.Pair1Column.ReadOnly = true;
            this.Pair1Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pair2Column
            // 
            this.Pair2Column.DataPropertyName = "Pair2";
            this.Pair2Column.FillWeight = 30F;
            this.Pair2Column.HeaderText = "2 Пара";
            this.Pair2Column.Name = "Pair2Column";
            this.Pair2Column.ReadOnly = true;
            this.Pair2Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pair3Column
            // 
            this.Pair3Column.DataPropertyName = "Pair3";
            this.Pair3Column.FillWeight = 30F;
            this.Pair3Column.HeaderText = "3 Пара";
            this.Pair3Column.Name = "Pair3Column";
            this.Pair3Column.ReadOnly = true;
            this.Pair3Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pair4Column
            // 
            this.Pair4Column.DataPropertyName = "Pair4";
            this.Pair4Column.FillWeight = 30F;
            this.Pair4Column.HeaderText = "4 Пара";
            this.Pair4Column.Name = "Pair4Column";
            this.Pair4Column.ReadOnly = true;
            this.Pair4Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pair5Column
            // 
            this.Pair5Column.DataPropertyName = "Pair5";
            this.Pair5Column.FillWeight = 30F;
            this.Pair5Column.HeaderText = "5 Пара";
            this.Pair5Column.Name = "Pair5Column";
            this.Pair5Column.ReadOnly = true;
            this.Pair5Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pair6Column
            // 
            this.Pair6Column.DataPropertyName = "Pair6";
            this.Pair6Column.FillWeight = 30F;
            this.Pair6Column.HeaderText = "6 Пара";
            this.Pair6Column.Name = "Pair6Column";
            this.Pair6Column.ReadOnly = true;
            this.Pair6Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NextDayButton
            // 
            this.NextDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextDayButton.Location = new System.Drawing.Point(275, 27);
            this.NextDayButton.MinimumSize = new System.Drawing.Size(35, 25);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(35, 25);
            this.NextDayButton.TabIndex = 3;
            this.NextDayButton.Text = ">";
            this.NextDayButton.UseVisualStyleBackColor = true;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // AttendanceToolStrip
            // 
            this.AttendanceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripButton,
            this.StudentToolStripComboBox});
            this.AttendanceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AttendanceToolStrip.Name = "AttendanceToolStrip";
            this.AttendanceToolStrip.Size = new System.Drawing.Size(432, 25);
            this.AttendanceToolStrip.TabIndex = 0;
            this.AttendanceToolStrip.Text = "toolStrip1";
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.CheckOnClick = true;
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.Image")));
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.EditToolStripButton.Text = "EditMode";
            // 
            // StudentToolStripComboBox
            // 
            this.StudentToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentToolStripComboBox.Name = "StudentToolStripComboBox";
            this.StudentToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.StudentToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentToolStripComboBox_SelectedIndexChanged);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 775);
            this.Controls.Add(this.AttendanceToolStrip);
            this.Controls.Add(this.PreviousDayButton);
            this.Controls.Add(this.LessonsDateTimePicker);
            this.Controls.Add(this.AttendanceDataGridView);
            this.Controls.Add(this.NextDayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AttendanceForm";
            this.Text = "Посещаемость";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGridView)).EndInit();
            this.AttendanceToolStrip.ResumeLayout(false);
            this.AttendanceToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PreviousDayButton;
        private System.Windows.Forms.DateTimePicker LessonsDateTimePicker;
        private System.Windows.Forms.DataGridView AttendanceDataGridView;
        private System.Windows.Forms.Button NextDayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair6Column;
        private System.Windows.Forms.ToolStrip AttendanceToolStrip;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripComboBox StudentToolStripComboBox;
    }
}

