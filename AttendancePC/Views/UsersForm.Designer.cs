namespace AttendancePC.Views
{
    partial class UsersForm
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
            this.GuestsListBox = new System.Windows.Forms.ListBox();
            this.RedactorsListBox = new System.Windows.Forms.ListBox();
            this.AddRedactorButton = new System.Windows.Forms.Button();
            this.RedactorLoginTextBox = new System.Windows.Forms.TextBox();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.GuestLoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.IsPrimeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteGuestButton = new System.Windows.Forms.Button();
            this.DeleteRedactorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuestsListBox
            // 
            this.GuestsListBox.FormattingEnabled = true;
            this.GuestsListBox.Location = new System.Drawing.Point(12, 12);
            this.GuestsListBox.Name = "GuestsListBox";
            this.GuestsListBox.Size = new System.Drawing.Size(225, 368);
            this.GuestsListBox.TabIndex = 0;
            // 
            // RedactorsListBox
            // 
            this.RedactorsListBox.FormattingEnabled = true;
            this.RedactorsListBox.Location = new System.Drawing.Point(400, 12);
            this.RedactorsListBox.Name = "RedactorsListBox";
            this.RedactorsListBox.Size = new System.Drawing.Size(221, 368);
            this.RedactorsListBox.TabIndex = 1;
            // 
            // AddRedactorButton
            // 
            this.AddRedactorButton.Location = new System.Drawing.Point(546, 466);
            this.AddRedactorButton.Name = "AddRedactorButton";
            this.AddRedactorButton.Size = new System.Drawing.Size(75, 23);
            this.AddRedactorButton.TabIndex = 14;
            this.AddRedactorButton.Text = "Добавить";
            this.AddRedactorButton.UseVisualStyleBackColor = true;
            this.AddRedactorButton.Click += new System.EventHandler(this.AddRedactorButton_Click);
            // 
            // RedactorLoginTextBox
            // 
            this.RedactorLoginTextBox.Location = new System.Drawing.Point(400, 409);
            this.RedactorLoginTextBox.Name = "RedactorLoginTextBox";
            this.RedactorLoginTextBox.Size = new System.Drawing.Size(221, 20);
            this.RedactorLoginTextBox.TabIndex = 13;
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Location = new System.Drawing.Point(162, 466);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(75, 23);
            this.AddGuestButton.TabIndex = 17;
            this.AddGuestButton.Text = "Добавить";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // GuestLoginTextBox
            // 
            this.GuestLoginTextBox.Location = new System.Drawing.Point(12, 409);
            this.GuestLoginTextBox.Name = "GuestLoginTextBox";
            this.GuestLoginTextBox.Size = new System.Drawing.Size(225, 20);
            this.GuestLoginTextBox.TabIndex = 16;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(400, 435);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(221, 20);
            this.PasswordTextBox.TabIndex = 19;
            // 
            // IsPrimeCheckBox
            // 
            this.IsPrimeCheckBox.AutoSize = true;
            this.IsPrimeCheckBox.Location = new System.Drawing.Point(12, 435);
            this.IsPrimeCheckBox.Name = "IsPrimeCheckBox";
            this.IsPrimeCheckBox.Size = new System.Drawing.Size(134, 17);
            this.IsPrimeCheckBox.TabIndex = 20;
            this.IsPrimeCheckBox.Text = "Расширенный доступ";
            this.IsPrimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Пароль";
            // 
            // DeleteGuestButton
            // 
            this.DeleteGuestButton.Location = new System.Drawing.Point(162, 383);
            this.DeleteGuestButton.Name = "DeleteGuestButton";
            this.DeleteGuestButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteGuestButton.TabIndex = 22;
            this.DeleteGuestButton.Text = "Удалить";
            this.DeleteGuestButton.UseVisualStyleBackColor = true;
            this.DeleteGuestButton.Click += new System.EventHandler(this.DeleteGuestButton_Click);
            // 
            // DeleteRedactorButton
            // 
            this.DeleteRedactorButton.Location = new System.Drawing.Point(546, 383);
            this.DeleteRedactorButton.Name = "DeleteRedactorButton";
            this.DeleteRedactorButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRedactorButton.TabIndex = 23;
            this.DeleteRedactorButton.Text = "Удалить";
            this.DeleteRedactorButton.UseVisualStyleBackColor = true;
            this.DeleteRedactorButton.Click += new System.EventHandler(this.DeleteRedactorButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 523);
            this.Controls.Add(this.DeleteRedactorButton);
            this.Controls.Add(this.DeleteGuestButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IsPrimeCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.GuestLoginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRedactorButton);
            this.Controls.Add(this.RedactorLoginTextBox);
            this.Controls.Add(this.RedactorsListBox);
            this.Controls.Add(this.GuestsListBox);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GuestsListBox;
        private System.Windows.Forms.ListBox RedactorsListBox;
        private System.Windows.Forms.Button AddRedactorButton;
        private System.Windows.Forms.TextBox RedactorLoginTextBox;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.TextBox GuestLoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox IsPrimeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteGuestButton;
        private System.Windows.Forms.Button DeleteRedactorButton;
    }
}