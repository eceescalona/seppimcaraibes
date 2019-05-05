namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IAddEditProduct
    {
        void EditProduct(Data.ORM.Product product);
        void RefreshView();
        void ShowFieldsWithError(Dictionary<string, string> fields);
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}