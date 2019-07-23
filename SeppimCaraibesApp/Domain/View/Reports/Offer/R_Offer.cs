namespace SeppimCaraibesApp.Domain.View.Reports.Offer
{
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_Offer : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Order _cOrder;


        public R_Offer()
        {
            InitializeComponent();
        }

        public R_Offer(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;
            _cOrder.LoadReport(this, code);
        }


        public void LoadData(IEnumerable<Data.POCO.OrderReportView> reportView)
        {
            DataSource = reportView;
        }
    }
}
