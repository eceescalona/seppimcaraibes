namespace SeppimCaraibesApp.Domain.Controller
{
    internal interface IListCustomers
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}
