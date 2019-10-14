namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ReportQuoteForm : Form
    {
        private const string NAME = "Vista Previa Cotización";

        private readonly C_Order _cOrder;


        #region Ctor
        public V_ReportQuoteForm()
        {
            InitializeComponent();
            _cOrder = new C_Order();
        }

        public V_ReportQuoteForm(C_Order cOrder, string code)
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
                var report = new Reports.Quote.R_Quote(_cOrder, code);
                quoteDV.DocumentSource = report;
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }
    }
}
