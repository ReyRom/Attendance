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
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(12, 14);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(259, 407);
            this.StudentsListBox.TabIndex = 1;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(317, 14);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(254, 20);
            this.StudentNameTextBox.TabIndex = 2;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(496, 40);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(75, 23);
            this.AddStudentButton.TabIndex = 3;
            this.AddStudentButton.Text = "Добавить";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // DismissedListBox
            // 
            this.DismissedListBox.FormattingEnabled = true;
            this.DismissedListBox.Location = new System.Drawing.Point(280, 313);
            this.DismissedListBox.Name = "DismissedListBox";
            this.DismissedListBox.Size = new System.Drawing.Size(291, 108);
            this.DismissedListBox.TabIndex = 5;
            // 
            // RecoverStudentButton
            // 
            this.RecoverStudentButton.Location = new System.Drawing.Point(280, 427);
            this.RecoverStudentButton.Name = "RecoverStudentButton";
            this.RecoverStudentButton.Size = new System.Drawing.Size(92, 23);
            this.RecoverStudentButton.TabIndex = 6;
            this.RecoverStudentButton.Text = "Восстановить";
            this.RecoverStudentButton.UseVisualStyleBackColor = true;
            this.RecoverStudentButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(479, 427);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteStudentButton.TabIndex = 7;
            this.DeleteStudentButton.Text = "Удалить";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DismissStudentButton
            // 
            this.DismissStudentButton.Location = new System.Drawing.Point(196, 427);
            this.DismissStudentButton.Name = "DismissStudentButton";
            this.DismissStudentButton.Size = new System.Drawing.Size(75, 23);
            this.DismissStudentButton.TabIndex = 8;
            this.DismissStudentButton.Text = "Отчислить";
            this.DismissStudentButton.UseVisualStyleBackColor = true;
            this.DismissStudentButton.Click += new System.EventHandler(this.DismissButton_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 459);
            this.Controls.Add(this.DismissStudentButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.RecoverStudentButton);
            this.Controls.Add(this.DismissedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.StudentsListBox);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
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
    }
}