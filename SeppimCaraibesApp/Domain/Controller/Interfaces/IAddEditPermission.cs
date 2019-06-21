namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IAddEditPermission
    {
        void EditPermission(Data.ORM.Permission permission);
        void RefreshView();
        void ShowFieldsWithError(Dictionary<string, string> fields);
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}
