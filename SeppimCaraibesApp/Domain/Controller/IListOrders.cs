namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListOrders
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}