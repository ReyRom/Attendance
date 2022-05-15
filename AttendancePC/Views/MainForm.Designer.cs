namespace AttendancePC.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ApplicationMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationMenuStrip
            // 
            this.ApplicationMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ApplicationMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AttendanceToolStripMenuItem,
            this.signInToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.SchedulesToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.ConnectionToolStripMenuItem,
            this.QueryToolStripMenuItem});
            this.ApplicationMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ApplicationMenuStrip.Name = "ApplicationMenuStrip";
            this.ApplicationMenuStrip.Size = new System.Drawing.Size(1055, 29);
            this.ApplicationMenuStrip.TabIndex = 1;
            this.ApplicationMenuStrip.Text = "menuStrip1";
            // 
            // AttendanceToolStripMenuItem
            // 
            this.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem";
            this.AttendanceToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.AttendanceToolStripMenuItem.Text = "Посещаемость";
            this.AttendanceToolStripMenuItem.Click += new System.EventHandler(this.AttendanceToolStripMenuItem_Click);
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.signInToolStripMenuItem.Text = "Войти";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.SignInToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.signOutToolStripMenuItem.Text = "Выйти";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // SchedulesToolStripMenuItem
            // 
            this.SchedulesToolStripMenuItem.Name = "SchedulesToolStripMenuItem";
            this.SchedulesToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.SchedulesToolStripMenuItem.Text = "Расписание";
            this.SchedulesToolStripMenuItem.Click += new System.EventHandler(this.SchedulesToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.ReportsToolStripMenuItem.Text = "Отчеты";
            this.ReportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersToolStripMenuItem,
            this.StudentsToolStripMenuItem,
            this.SubjectsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.UsersToolStripMenuItem.Text = "Пользователи";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // StudentsToolStripMenuItem
            // 
            this.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
            this.StudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.StudentsToolStripMenuItem.Text = "Студенты";
            this.StudentsToolStripMenuItem.Click += new System.EventHandler(this.StudentsToolStripMenuItem_Click);
            // 
            // SubjectsToolStripMenuItem
            // 
            this.SubjectsToolStripMenuItem.Name = "SubjectsToolStripMenuItem";
            this.SubjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.SubjectsToolStripMenuItem.Text = "Предметы";
            this.SubjectsToolStripMenuItem.Click += new System.EventHandler(this.SubjectsToolStripMenuItem_Click);
            // 
            // ConnectionToolStripMenuItem
            // 
            this.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem";
            this.ConnectionToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.ConnectionToolStripMenuItem.Text = "Соединение";
            this.ConnectionToolStripMenuItem.Click += new System.EventHandler(this.ConnectionToolStripMenuItem_Click);
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.QueryToolStripMenuItem.Text = "Запрос";
            this.QueryToolStripMenuItem.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 534);
            this.Controls.Add(this.ApplicationMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ApplicationMenuStrip;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ApplicationMenuStrip.ResumeLayout(false);
            this.ApplicationMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ApplicationMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SchedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
    }
}