namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.AccountsReceivableCustomer
{
    using System;
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_AccountsReceivableCustomer : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Report _cReport;

        public R_AccountsReceivableCustomer()
        {
            InitializeComponent();
        }

        public R_AccountsReceivableCustomer(Controller.C_Report cReport)
        {
            InitializeComponent();
            _cReport = cReport;
            _cReport.LoadAccountsReceivableCustomer(this);
        }

        public void LoadData(IEnumerable<Data.POCO.AccountReceivable> reportView)
        {
            DataSource = reportView;
        }

        public void LoadData(IEnumerable<Data.POCO.TotalSales> reportView)
        {
            throw new NotImplementedException();
        }

        public void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView)
        {
            throw new NotImplementedException();
        }
    }
}
