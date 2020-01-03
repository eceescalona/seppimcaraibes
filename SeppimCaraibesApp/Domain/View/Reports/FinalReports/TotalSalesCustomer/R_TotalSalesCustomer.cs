namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSalesCustomer
{
    using System;
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_TotalSalesCustomer : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Report _cReport;

        public R_TotalSalesCustomer()
        {
            InitializeComponent();
        }

        public R_TotalSalesCustomer(Controller.C_Report cReport)
        {
            InitializeComponent();
            _cReport = cReport;
            _cReport.LoadTotalSalesCustomer(this);
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
