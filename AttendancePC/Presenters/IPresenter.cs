using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendancePC.Presenters
{
    public interface IPresenter
    {
        event EventHandler<EventArgs> RenewEvent;
    }
}
