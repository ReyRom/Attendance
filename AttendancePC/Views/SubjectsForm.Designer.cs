namespace AttendancePC.Views
{
    partial class SubjectsForm
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
            this.DeactualizeSubjectButton = new System.Windows.Forms.Button();
            this.DeleteSubjectButton = new System.Windows.Forms.Button();
            this.RecoverSubjectButton = new System.Windows.Forms.Button();
            this.NonActualListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.SubjectsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeactualizeSubjectButton
            // 
            this.DeactualizeSubjectButton.Location = new System.Drawing.Point(196, 425);
            this.DeactualizeSubjectButton.Name = "DeactualizeSubjectButton";
            this.DeactualizeSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.DeactualizeSubjectButton.TabIndex = 16;
            this.DeactualizeSubjectButton.Text = "Убрать";
            this.DeactualizeSubjectButton.UseVisualStyleBackColor = true;
            this.DeactualizeSubjectButton.Click += new System.EventHandler(this.DeactualizeSubjectButton_Click);
            // 
            // DeleteSubjectButton
            // 
            this.DeleteSubjectButton.Location = new System.Drawing.Point(479, 425);
            this.DeleteSubjectButton.Name = "DeleteSubjectButton";
            this.DeleteSubjectButton.Size = new System.Drawing.Size(92, 23);
            this.DeleteSubjectButton.TabIndex = 15;
            this.DeleteSubjectButton.Text = "Удалить";
            this.DeleteSubjectButton.UseVisualStyleBackColor = true;
            this.DeleteSubjectButton.Click += new System.EventHandler(this.DeleteSubjectButton_Click);
            // 
            // RecoverSubjectButton
            // 
            this.RecoverSubjectButton.Location = new System.Drawing.Point(280, 425);
            this.RecoverSubjectButton.Name = "RecoverSubjectButton";
            this.RecoverSubjectButton.Size = new System.Drawing.Size(92, 23);
            this.RecoverSubjectButton.TabIndex = 14;
            this.RecoverSubjectButton.Text = "Восстановить";
            this.RecoverSubjectButton.UseVisualStyleBackColor = true;
            this.RecoverSubjectButton.Click += new System.EventHandler(this.RecoverSubjectButton_Click);
            // 
            // NonActualListBox
            // 
            this.NonActualListBox.FormattingEnabled = true;
            this.NonActualListBox.Location = new System.Drawing.Point(280, 311);
            this.NonActualListBox.Name = "NonActualListBox";
            this.NonActualListBox.Size = new System.Drawing.Size(291, 108);
            this.NonActualListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Предмет";
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(496, 38);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.AddSubjectButton.TabIndex = 11;
            this.AddSubjectButton.Text = "Добавить";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.Location = new System.Drawing.Point(335, 12);
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.SubjectNameTextBox.TabIndex = 10;
            // 
            // SubjectsListBox
            // 
            this.SubjectsListBox.FormattingEnabled = true;
            this.SubjectsListBox.Location = new System.Drawing.Point(12, 12);
            this.SubjectsListBox.Name = "SubjectsListBox";
            this.SubjectsListBox.Size = new System.Drawing.Size(259, 407);
            this.SubjectsListBox.TabIndex = 9;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 458);
            this.Controls.Add(this.DeactualizeSubjectButton);
            this.Controls.Add(this.DeleteSubjectButton);
            this.Controls.Add(this.RecoverSubjectButton);
            this.Controls.Add(this.NonActualListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.SubjectNameTextBox);
            this.Controls.Add(this.SubjectsListBox);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeactualizeSubjectButton;
        private System.Windows.Forms.Button DeleteSubjectButton;
        private System.Windows.Forms.Button RecoverSubjectButton;
        private System.Windows.Forms.ListBox NonActualListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.TextBox SubjectNameTextBox;
        public System.Windows.Forms.ListBox SubjectsListBox;
    }
}