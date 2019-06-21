namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface ISelectProvider
    {
        void RefreshView();

        void ShowFieldsWithError(string field, string message);

        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}