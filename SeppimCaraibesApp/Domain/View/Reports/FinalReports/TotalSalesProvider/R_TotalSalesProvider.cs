namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSalesProvider
{
    using System;
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_TotalSalesProvider : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Report _cReport;

        public R_TotalSalesProvider()
        {
            InitializeComponent();
        }

        public R_TotalSalesProvider(Controller.C_Report cReport)
        {
            InitializeComponent();
            _cReport = cReport;
            _cReport.LoadTotalSalesProvider(this);
        }

        public void LoadData(IEnumerable<Data.POCO.TotalSales> reportView)
        {          
            DataSource = reportView;
        }

        public void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView)
        {
            throw new NotImplementedException();
        }
    }
}
