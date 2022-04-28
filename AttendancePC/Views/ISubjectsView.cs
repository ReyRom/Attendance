namespace AttendancePC.Views
{
    public interface ISubjectsView: IView
    {
        object Subjects
        {
            set;
        }

        object NonActual
        {
            set;
        }
    }
}