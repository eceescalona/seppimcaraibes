namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ReportOrderForm : Form
    {
        private const string NAME = "Vista Previa Orden";

        private readonly C_Order _cOrder;


        #region Ctor
        public V_ReportOrderForm()
        {
            InitializeComponent();
            _cOrder = new C_Order();
        }

        public V_ReportOrderForm(C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code, true);
        }

        public V_ReportOrderForm(C_Order cOrder, string code, bool flag)
        {
            InitializeComponent();
            _cOrder = cOrder;

            Text = NAME;

            LoadDocumentSource(code, flag);
        }
        #endregion


        private void LoadDocumentSource(string code, bool flag)
        {
            try
            {
                if (flag)
                {
                    var report = new Reports.Order.R_Order(_cOrder, code);
                    orderDV.DocumentSource = report;
                }
                else
                {
                    var report = new Reports.Order.R_Order(_cOrder, code, flag);
                    orderDV.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }
    }
}
