namespace SeppimCaraibesApp.Domain.View.Order
{
    using System.Windows.Forms;

    internal partial class V_ReportOfferForm : Form
    {
        private const string NAME = "Vista Previa Oferta";

        private readonly Controller.C_Order _cOrder;


        public V_ReportOfferForm()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
        }

        public V_ReportOfferForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code);
        }


        private void LoadDocumentSource(string code)
        {
            var report = new Reports.Offer.R_Offer(_cOrder, code);
            offerDV.DocumentSource = report;
        }
    }
}
