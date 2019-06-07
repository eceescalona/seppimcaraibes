namespace SeppimCaraibesApp.Domain.View.Order
{
    using System.Windows.Forms;

    internal partial class V_ReportOrderForm : Form
    {
        private const string NAME = "Vista Previa Orden";

        private readonly Controller.C_Order _cOrder;

        public V_ReportOrderForm()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public V_ReportOrderForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code);
        }

        private void LoadDocumentSource(string code)
        {
            var report = new Reports.Order.R_Order(_cOrder, code);
            orderDV.DocumentSource = report;
        }
    }
}
