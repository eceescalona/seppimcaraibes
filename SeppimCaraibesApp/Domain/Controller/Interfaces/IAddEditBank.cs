namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IAddEditBank
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage information, string message);
        void ShowFieldsWithError(Dictionary<string, string> fields);
    }
}