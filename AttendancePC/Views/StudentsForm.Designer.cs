namespace AttendancePC.Views
{
    partial class StudentsForm
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
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DismissedListBox = new System.Windows.Forms.ListBox();
            this.RecoverStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.DismissStudentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 20;
            this.StudentsListBox.Location = new System.Drawing.Point(12, 39);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(259, 164);
            this.StudentsListBox.TabIndex = 1;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentNameTextBox.Location = new System.Drawing.Point(330, 14);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(241, 26);
            this.StudentNameTextBox.TabIndex = 2;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentButton.Location = new System.Drawing.Point(473, 46);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(99, 33);
            this.AddStudentButton.TabIndex = 3;
            this.AddStudentButton.Text = "Добавить";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(277, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // DismissedListBox
            // 
            this.DismissedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DismissedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DismissedListBox.FormattingEnabled = true;
            this.DismissedListBox.ItemHeight = 20;
            this.DismissedListBox.Location = new System.Drawing.Point(280, 99);
            this.DismissedListBox.Name = "DismissedListBox";
            this.DismissedListBox.Size = new System.Drawing.Size(291, 104);
            this.DismissedListBox.TabIndex = 5;
            // 
            // RecoverStudentButton
            // 
            this.RecoverStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RecoverStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecoverStudentButton.Location = new System.Drawing.Point(280, 212);
            this.RecoverStudentButton.Name = "RecoverStudentButton";
            this.RecoverStudentButton.Size = new System.Drawing.Size(130, 38);
            this.RecoverStudentButton.TabIndex = 6;
            this.RecoverStudentButton.Text = "Восстановить";
            this.RecoverStudentButton.UseVisualStyleBackColor = true;
            this.RecoverStudentButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentButton.Location = new System.Drawing.Point(472, 212);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(99, 38);
            this.DeleteStudentButton.TabIndex = 7;
            this.DeleteStudentButton.Text = "Удалить";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DismissStudentButton
            // 
            this.DismissStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DismissStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DismissStudentButton.Location = new System.Drawing.Point(162, 212);
            this.DismissStudentButton.Name = "DismissStudentButton";
            this.DismissStudentButton.Size = new System.Drawing.Size(109, 38);
            this.DismissStudentButton.TabIndex = 8;
            this.DismissStudentButton.Text = "Отчислить";
            this.DismissStudentButton.UseVisualStyleBackColor = true;
            this.DismissStudentButton.Click += new System.EventHandler(this.DismissButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Студенты";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(277, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчислены";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DismissStudentButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.RecoverStudentButton);
            this.Controls.Add(this.DismissedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.StudentsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "StudentsForm";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.SudentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DismissedListBox;
        private System.Windows.Forms.Button RecoverStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button DismissStudentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}