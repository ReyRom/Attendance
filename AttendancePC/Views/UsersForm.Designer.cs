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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuestsListBox
            // 
            this.GuestsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GuestsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestsListBox.FormattingEnabled = true;
            this.GuestsListBox.ItemHeight = 20;
            this.GuestsListBox.Location = new System.Drawing.Point(27, 32);
            this.GuestsListBox.Name = "GuestsListBox";
            this.GuestsListBox.Size = new System.Drawing.Size(266, 104);
            this.GuestsListBox.TabIndex = 0;
            // 
            // RedactorsListBox
            // 
            this.RedactorsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedactorsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedactorsListBox.FormattingEnabled = true;
            this.RedactorsListBox.ItemHeight = 20;
            this.RedactorsListBox.Location = new System.Drawing.Point(336, 32);
            this.RedactorsListBox.Name = "RedactorsListBox";
            this.RedactorsListBox.Size = new System.Drawing.Size(269, 104);
            this.RedactorsListBox.TabIndex = 1;
            // 
            // AddRedactorButton
            // 
            this.AddRedactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRedactorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRedactorButton.Location = new System.Drawing.Point(499, 257);
            this.AddRedactorButton.Name = "AddRedactorButton";
            this.AddRedactorButton.Size = new System.Drawing.Size(106, 32);
            this.AddRedactorButton.TabIndex = 14;
            this.AddRedactorButton.Text = "Добавить";
            this.AddRedactorButton.UseVisualStyleBackColor = true;
            this.AddRedactorButton.Click += new System.EventHandler(this.AddRedactorButton_Click);
            // 
            // RedactorLoginTextBox
            // 
            this.RedactorLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RedactorLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedactorLoginTextBox.Location = new System.Drawing.Point(384, 186);
            this.RedactorLoginTextBox.Name = "RedactorLoginTextBox";
            this.RedactorLoginTextBox.Size = new System.Drawing.Size(221, 26);
            this.RedactorLoginTextBox.TabIndex = 13;
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGuestButton.Location = new System.Drawing.Point(192, 256);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(101, 33);
            this.AddGuestButton.TabIndex = 17;
            this.AddGuestButton.Text = "Добавить";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // GuestLoginTextBox
            // 
            this.GuestLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuestLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestLoginTextBox.Location = new System.Drawing.Point(68, 186);
            this.GuestLoginTextBox.Name = "GuestLoginTextBox";
            this.GuestLoginTextBox.Size = new System.Drawing.Size(225, 26);
            this.GuestLoginTextBox.TabIndex = 16;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(384, 225);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(221, 26);
            this.PasswordTextBox.TabIndex = 19;
            // 
            // IsPrimeCheckBox
            // 
            this.IsPrimeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IsPrimeCheckBox.AutoSize = true;
            this.IsPrimeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsPrimeCheckBox.Location = new System.Drawing.Point(68, 227);
            this.IsPrimeCheckBox.Name = "IsPrimeCheckBox";
            this.IsPrimeCheckBox.Size = new System.Drawing.Size(190, 24);
            this.IsPrimeCheckBox.TabIndex = 20;
            this.IsPrimeCheckBox.Text = "Расширенный доступ";
            this.IsPrimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(311, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Пароль";
            // 
            // DeleteGuestButton
            // 
            this.DeleteGuestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteGuestButton.Location = new System.Drawing.Point(192, 152);
            this.DeleteGuestButton.Name = "DeleteGuestButton";
            this.DeleteGuestButton.Size = new System.Drawing.Size(101, 28);
            this.DeleteGuestButton.TabIndex = 22;
            this.DeleteGuestButton.Text = "Удалить";
            this.DeleteGuestButton.UseVisualStyleBackColor = true;
            this.DeleteGuestButton.Click += new System.EventHandler(this.DeleteGuestButton_Click);
            // 
            // DeleteRedactorButton
            // 
            this.DeleteRedactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRedactorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRedactorButton.Location = new System.Drawing.Point(499, 152);
            this.DeleteRedactorButton.Name = "DeleteRedactorButton";
            this.DeleteRedactorButton.Size = new System.Drawing.Size(106, 28);
            this.DeleteRedactorButton.TabIndex = 23;
            this.DeleteRedactorButton.Text = "Удалить";
            this.DeleteRedactorButton.UseVisualStyleBackColor = true;
            this.DeleteRedactorButton.Click += new System.EventHandler(this.DeleteRedactorButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Гости";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(336, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Редакторы";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(645, 1000);
            this.MinimumSize = new System.Drawing.Size(645, 345);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}