namespace SeppimCaraibesApp.Domain.View.Reports.Invoice
{
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_Invoice : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Order _cOrder;


        public R_Invoice()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public R_Invoice(Controller.C_Order cOrder, string code)
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
