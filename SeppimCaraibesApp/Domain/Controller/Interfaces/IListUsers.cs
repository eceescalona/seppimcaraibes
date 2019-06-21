namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListUsers
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}
