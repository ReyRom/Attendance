namespace AttendancePC.Views
{
    internal interface IQueryView: IView
    {
        string Query { get; }
    }
}