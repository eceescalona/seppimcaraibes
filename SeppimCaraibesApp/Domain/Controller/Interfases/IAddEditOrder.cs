namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;
    using System.Data.Entity;

    internal interface IAddEditOrder
    {
        void EditOrder(Data.ORM.Order order);
        void RefreshView();
        void ShowFieldsWithError(Dictionary<string, string> fields);
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}