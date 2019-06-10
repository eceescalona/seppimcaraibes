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
            _cOrder = new Controller.C_Order();
        }

        public V_ReportInvoiceForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code);
        }


        private void LoadDocumentSource(string code)
        {
            var report = new Reports.Invoice.R_Invoice(_cOrder, code);
            invoiceDV.DocumentSource = report;
        }
    }
}
