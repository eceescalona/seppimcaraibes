namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListProducts
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}