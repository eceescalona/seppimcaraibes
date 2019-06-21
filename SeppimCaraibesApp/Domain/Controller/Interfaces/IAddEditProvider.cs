namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IAddEditProvider
    {
        void EditProvider(Data.ORM.Provider provider);
        void RefreshView();
        void ShowFieldsWithError(Dictionary<string, string> fields);
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}