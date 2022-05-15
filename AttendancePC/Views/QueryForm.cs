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
    public partial class QueryForm : Form, IQueryView
    {
        QueryPresenter presenter;
        public QueryForm()
        {
            InitializeComponent();

            presenter = new QueryPresenter(this);
        }

        public string Query
        {
            get
            {
                return QueryTextBox.Text;
            }
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            presenter.ExecCommand();
        }
    }
}
