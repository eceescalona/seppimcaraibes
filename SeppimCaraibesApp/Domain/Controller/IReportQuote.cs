namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;
    internal interface IReportQuote
    {
        void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView);
    }
}
