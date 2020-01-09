namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSales
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ReportTotalSales : Form
    {
        private const string NAME = "Total de Ventas";

        private readonly C_Report _cReport;


        #region Ctor
        public V_ReportTotalSales()
        {
            InitializeComponent();
            _cReport = new C_Report();
        }

        public V_ReportTotalSales(C_Report cReport, EPeriod period)
        {
            InitializeComponent();
            _cReport = cReport;

            Text = NAME;

            LoadDocumentSource(period);
        }
        #endregion


        private void LoadDocumentSource(EPeriod period)
        {
            try
            {
                var report = new R_TotalSales(_cReport, period);
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
