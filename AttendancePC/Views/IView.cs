using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendancePC.Views
{
    public interface IView
    {
        event FormClosedEventHandler FormClosed;
        Form MdiParent { get; set; }

        void Show();
        void Close();
    }
}
