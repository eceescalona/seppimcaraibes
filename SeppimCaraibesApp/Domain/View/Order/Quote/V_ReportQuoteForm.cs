﻿namespace SeppimCaraibesApp.Domain.View.Order
{
    using System.Windows.Forms;

    internal partial class V_ReportQuoteForm : Form
    {
        private const string NAME = "Vista Previa Cotización";

        private Controller.C_Order _cOrder;

        public V_ReportQuoteForm()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public V_ReportQuoteForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code);
        }

        private void LoadDocumentSource(string code)
        {
            var report = new Reports.Quote.R_Quote(_cOrder, code);
            quoteDV.DocumentSource = report;
        }
    }
}
