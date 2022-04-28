using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Views
{
    public interface IStudentsView: IView
    {
        object Students
        {
            set;
        }

        object Dismissed
        {
            set;
        }
    }
}
