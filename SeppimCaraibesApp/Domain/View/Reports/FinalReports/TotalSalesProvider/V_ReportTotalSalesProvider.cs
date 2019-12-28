namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSalesProvider
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ReportTotalSalesProvider : Form
    {
        private const string NAME = "Total de Ventas por Proveedor";

        private readonly C_Report _cReport;


        #region Ctor
        public V_ReportTotalSalesProvider()
        {
            InitializeComponent();
            _cReport = new C_Report();
        }

        public V_ReportTotalSalesProvider(C_Report cReport)
        {
            InitializeComponent();
            _cReport = cReport;

            Text = NAME;

            LoadDocumentSource();
        }
        #endregion


        private void LoadDocumentSource()
        {
            try
            {
                var report = new R_TotalSalesProvider(_cReport);
                totalSalesDV.DocumentSource = report;
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }
    }
}
