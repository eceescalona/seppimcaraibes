namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListPermissions
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}
