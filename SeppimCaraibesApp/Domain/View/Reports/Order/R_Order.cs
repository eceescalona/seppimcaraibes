namespace SeppimCaraibesApp.Domain.View.Reports.Order
{
    using DevExpress.XtraReports.UI;
    using System.Collections.Generic;

    internal partial class R_Order : XtraReport, Controller.IReport
    {
        private readonly Controller.C_Order _cOrder;


        public R_Order()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public R_Order(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;
            _cOrder.LoadReport(this, code);
        }

        public R_Order(Controller.C_Order cOrder, string code, bool flag)
        {
            InitializeComponent();

            xrTableCell4.Visible = flag;
            xrTableCell10.Visible = flag;
            xrTableCell5.Visible = flag;
            xrTableCell6.Visible = flag;

            xrTable1.ProcessHiddenCellMode = ProcessHiddenCellMode.ResizeCellsEqually;
            xrTable2.ProcessHiddenCellMode = ProcessHiddenCellMode.ResizeCellsEqually;
            totalCostXRL.Visible = false;
            xrLabel31.Visible = false;
            xrLabel21.Visible = false;
            xrLabel24.Visible = false;
            xrLabel20.Visible = false;
            xrLabel11.Visible = false;
            xrLabel12.Visible = false;
            xrLabel13.Visible = false;
            xrLabel16.Visible = false;
            xrLabel17.Visible = false;
            xrShape1.Visible = false;

            GroupFooter2.Visible = false;

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
