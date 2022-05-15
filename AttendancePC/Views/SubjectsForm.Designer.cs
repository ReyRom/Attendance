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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeactualizeSubjectButton
            // 
            this.DeactualizeSubjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeactualizeSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeactualizeSubjectButton.Location = new System.Drawing.Point(171, 222);
            this.DeactualizeSubjectButton.Name = "DeactualizeSubjectButton";
            this.DeactualizeSubjectButton.Size = new System.Drawing.Size(102, 28);
            this.DeactualizeSubjectButton.TabIndex = 16;
            this.DeactualizeSubjectButton.Text = "Убрать";
            this.DeactualizeSubjectButton.UseVisualStyleBackColor = true;
            this.DeactualizeSubjectButton.Click += new System.EventHandler(this.DeactualizeSubjectButton_Click);
            // 
            // DeleteSubjectButton
            // 
            this.DeleteSubjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSubjectButton.Location = new System.Drawing.Point(462, 222);
            this.DeleteSubjectButton.Name = "DeleteSubjectButton";
            this.DeleteSubjectButton.Size = new System.Drawing.Size(111, 28);
            this.DeleteSubjectButton.TabIndex = 15;
            this.DeleteSubjectButton.Text = "Удалить";
            this.DeleteSubjectButton.UseVisualStyleBackColor = true;
            this.DeleteSubjectButton.Click += new System.EventHandler(this.DeleteSubjectButton_Click);
            // 
            // RecoverSubjectButton
            // 
            this.RecoverSubjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RecoverSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecoverSubjectButton.Location = new System.Drawing.Point(283, 222);
            this.RecoverSubjectButton.Name = "RecoverSubjectButton";
            this.RecoverSubjectButton.Size = new System.Drawing.Size(129, 28);
            this.RecoverSubjectButton.TabIndex = 14;
            this.RecoverSubjectButton.Text = "Восстановить";
            this.RecoverSubjectButton.UseVisualStyleBackColor = true;
            this.RecoverSubjectButton.Click += new System.EventHandler(this.RecoverSubjectButton_Click);
            // 
            // NonActualListBox
            // 
            this.NonActualListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NonActualListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NonActualListBox.FormattingEnabled = true;
            this.NonActualListBox.ItemHeight = 20;
            this.NonActualListBox.Location = new System.Drawing.Point(281, 92);
            this.NonActualListBox.Name = "NonActualListBox";
            this.NonActualListBox.Size = new System.Drawing.Size(291, 124);
            this.NonActualListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Предмет";
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSubjectButton.Location = new System.Drawing.Point(481, 44);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(92, 31);
            this.AddSubjectButton.TabIndex = 11;
            this.AddSubjectButton.Text = "Добавить";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectNameTextBox.Location = new System.Drawing.Point(364, 12);
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(209, 26);
            this.SubjectNameTextBox.TabIndex = 10;
            // 
            // SubjectsListBox
            // 
            this.SubjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectsListBox.FormattingEnabled = true;
            this.SubjectsListBox.ItemHeight = 20;
            this.SubjectsListBox.Location = new System.Drawing.Point(12, 32);
            this.SubjectsListBox.Name = "SubjectsListBox";
            this.SubjectsListBox.Size = new System.Drawing.Size(261, 184);
            this.SubjectsListBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Учебные дисциплины";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(279, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Не актуально";
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeactualizeSubjectButton);
            this.Controls.Add(this.DeleteSubjectButton);
            this.Controls.Add(this.RecoverSubjectButton);
            this.Controls.Add(this.NonActualListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.SubjectNameTextBox);
            this.Controls.Add(this.SubjectsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "SubjectsForm";
            this.Text = "Учебные дисциплины";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}