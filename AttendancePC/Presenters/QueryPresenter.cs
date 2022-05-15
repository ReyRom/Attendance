using AttendancePC.Supporting;
using AttendancePC.Views;
using System;

namespace AttendancePC.Presenters
{
    internal class QueryPresenter
    {
        IQueryView view;

        public QueryPresenter(IQueryView view)
        {
            this.view = view;
        }

        internal void ExecCommand()
        {
            try
            {
                var result = Core.Context.Database.ExecuteSqlCommand(view.Query);
                UserFeedback.InformationMessage($"Команда выплнена, изменено строк: {result}");
            }
            catch (Exception ex)
            {
                UserFeedback.ErrorMessage(ex);
            }
        }
    }
}