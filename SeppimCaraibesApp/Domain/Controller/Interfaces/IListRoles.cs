namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListRoles
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}
