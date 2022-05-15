namespace AttendancePC.Views
{
    partial class QueryForm
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
            this.ExecButton = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecButton
            // 
            this.ExecButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecButton.Location = new System.Drawing.Point(606, 425);
            this.ExecButton.Name = "ExecButton";
            this.ExecButton.Size = new System.Drawing.Size(110, 33);
            this.ExecButton.TabIndex = 0;
            this.ExecButton.Text = "Выполнить";
            this.ExecButton.UseVisualStyleBackColor = true;
            this.ExecButton.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.AcceptsReturn = true;
            this.QueryTextBox.AcceptsTab = true;
            this.QueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueryTextBox.Location = new System.Drawing.Point(13, 12);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(703, 407);
            this.QueryTextBox.TabIndex = 1;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 470);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.ExecButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "QueryForm";
            this.Text = "Выполнить DML/DDL команду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecButton;
        private System.Windows.Forms.TextBox QueryTextBox;
    }
}