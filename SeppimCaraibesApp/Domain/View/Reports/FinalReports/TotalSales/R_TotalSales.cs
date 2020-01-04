namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSales
{
    using System;
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_TotalSales : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Report _cReport;

        public R_TotalSales()
        {
            InitializeComponent();
        }

        public R_TotalSales(Controller.C_Report cReport, EPeriod period)
        {
            InitializeComponent();
            _cReport = cReport;
            _cReport.LoadTotalSales(this, period);
        }

        public void LoadData(IEnumerable<Data.POCO.TotalSales> reportView)
        {          
            DataSource = reportView;
        }

        public void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView)
        {
            throw new NotImplementedException();
        }

        public void LoadData(IEnumerable<Data.POCO.AccountReceivable> reportView)
        {
            throw new NotImplementedException();
        }
    }
}
