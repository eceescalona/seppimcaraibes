namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListProviders
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}