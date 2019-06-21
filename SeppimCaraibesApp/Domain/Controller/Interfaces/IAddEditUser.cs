namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IAddEditUser
    {
        void EditUser(Data.ORM.User user);
        void RefreshView();
        void ShowFieldsWithError(Dictionary<string, string> fields);
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}
