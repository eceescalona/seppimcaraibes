﻿namespace SeppimCaraibesApp.Domain.View.Reports.Quote
{
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_Quote : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Order _cOrder;


        public R_Quote()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public R_Quote(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;
            _cOrder.LoadReport(this, code);
        }


        public void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView)
        {
            DataSource = reportView;
        }

        public void LoadData(IEnumerable<Data.POCO.TotalSales> reportView)
        {
            throw new System.NotImplementedException();
        }

        public void LoadData(IEnumerable<Data.POCO.AccountReceivable> reportView)
        {
            throw new System.NotImplementedException();
        }
    }
}
