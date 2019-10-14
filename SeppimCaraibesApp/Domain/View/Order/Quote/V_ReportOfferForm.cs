namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ReportOfferForm : Form
    {
        private const string NAME = "Vista Previa Oferta";

        private readonly C_Order _cOrder;


        #region Ctor
        public V_ReportOfferForm()
        {
            InitializeComponent();
            _cOrder = new C_Order();
        }

        public V_ReportOfferForm(C_Order cOrder, string code)
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
                var report = new Reports.Offer.R_Offer(_cOrder, code);
                offerDV.DocumentSource = report;
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }
    }
}
