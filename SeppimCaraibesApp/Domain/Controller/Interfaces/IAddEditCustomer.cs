namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IAddEditCustomer
    {
        void EditCustomer(Data.ORM.Customer customer);
        void RefreshView();
        void ShowFieldsWithError(Dictionary<string, string> fields);
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}