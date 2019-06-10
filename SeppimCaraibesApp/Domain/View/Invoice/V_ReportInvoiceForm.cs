namespace SeppimCaraibesApp.Domain.View.Invoice
{
    using System.Windows.Forms;

    internal partial class V_ReportInvoiceForm : Form
    {
        private const string NAME = "Vista Previa Factura";

        private readonly Controller.C_Order _cOrder;


        public V_ReportInvoiceForm()
        {
            InitializeComponent();
        }

        public V_ReportInvoiceForm(Controller.C_Order cOrder, string code)
        {
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code);
        }


        private void LoadDocumentSource(string code)
        {
            var report = new Reports.Order.R_Order(_cOrder, code);
            invoiceDV.DocumentSource = report;
        }
    }
}
