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
    public partial class SubjectsForm : Form, ISubjectsView
    {
        SubjectsPresenter presenter;

        #region Controls
        public object Subjects
        {
            set
            {
                SubjectsListBox.DataSource = value;
            }
        }

        public object NonActual
        {
            set
            {
                NonActualListBox.DataSource = value;
            }
        }
        #endregion

        public SubjectsForm()
        {
            InitializeComponent();
            presenter = new SubjectsPresenter(this);

            SubjectsListBox.DisplayMember = "Name";
            NonActualListBox.DisplayMember = "Name";
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void DeactualizeSubjectButton_Click(object sender, EventArgs e)
        {
            presenter.DeactualizeSubject(SubjectsListBox.SelectedItem);
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            presenter.AddSubject(SubjectNameTextBox.Text);
        }

        private void RecoverSubjectButton_Click(object sender, EventArgs e)
        {
            presenter.RecoverSubject(NonActualListBox.SelectedItem);
        }

        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteSubject(NonActualListBox.SelectedItem);
        }
    }
}
