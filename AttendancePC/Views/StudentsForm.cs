using AttendancePC.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public partial class StudentsForm : Form, IStudentsView
    {
        StudentsPresenter presenter;

        #region Controls
        public object Students
        {
            set 
            {
                StudentsListBox.DataSource = value;
            }
        }

        public object Dismissed
        {
            set
            {
                DismissedListBox.DataSource = value;
            }
        }
        #endregion

        public StudentsForm()
        {
            InitializeComponent();
            presenter = new StudentsPresenter(this);

            StudentsListBox.DisplayMember = "Name";
            DismissedListBox.DisplayMember = "Name";
        }

        private void SudentsForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            presenter.AddStudent(StudentNameTextBox.Text);
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            presenter.RecoverStudent(DismissedListBox.SelectedItem);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteStudent(DismissedListBox.SelectedItem);
        }

        private void DismissButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteStudent(StudentsListBox.SelectedItem);
        }
    }
}
