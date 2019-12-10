namespace SeppimCaraibesApp.Domain.View.Invoice
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ReportInvoiceForm : Form
    {
        private const string NAME = "Vista Previa Factura";

        private readonly C_Order _cOrder;


        #region Ctor
        public V_ReportInvoiceForm()
        {
            InitializeComponent();
            _cOrder = new C_Order();
        }

        public V_ReportInvoiceForm(C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code);
        }
        #endregion


        private void LoadDocumentSource(string code)
        {
            try
            {
                var report = new Reports.Invoice.R_Invoice(_cOrder, code);
                invoiceDV.DocumentSource = report;
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }
    }
}
