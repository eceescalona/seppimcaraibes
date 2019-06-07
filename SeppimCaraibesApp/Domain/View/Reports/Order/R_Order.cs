﻿namespace SeppimCaraibesApp.Domain.View.Reports.Order
{
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_Order : XtraReport, Controller.IReport
    {
        private Controller.C_Order _cOrder;

        public R_Order()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public R_Order(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;
            _cOrder.LoadQuoteReport(this, code);
        }

        public void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView)
        {
            DataSource = reportView;
        }
    }
}
