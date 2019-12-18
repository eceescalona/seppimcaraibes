namespace SeppimCaraibesApp.Domain.Controller
{
    using System;

    internal class C_Report: IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Report _mReport;

        public C_Report()
        {
            _mReport = new Model.Report();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        public void LoadReport(IReport reportQuote, EPeriod period)
        {
            var reportData = _mReport.GetTotalSales(_context, period);
            reportQuote.LoadData(reportData);
        }
    }
}
