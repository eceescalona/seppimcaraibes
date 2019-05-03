namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IListProviders
    {
        void RefreshView();
        void ShowMessage(ETypeOfMessage typeOfMessage, string message);
    }
}