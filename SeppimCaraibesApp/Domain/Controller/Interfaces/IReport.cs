namespace SeppimCaraibesApp.Domain.Controller
{
    using System.Collections.Generic;

    internal interface IReport
    {
        void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView);
        void LoadData(IEnumerable<Data.POCO.TotalSales> reportView);
        void LoadData(IEnumerable<Data.POCO.AccountReceivable> reportView);
    }
}
