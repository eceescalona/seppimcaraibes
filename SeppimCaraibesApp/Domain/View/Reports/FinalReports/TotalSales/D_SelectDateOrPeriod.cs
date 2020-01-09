namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSales
{
    using System;
    using System.Windows.Forms;

    internal partial class D_SelectDateOrPeriod : Form
    {
        public EPeriod Period { get; set; }


        public D_SelectDateOrPeriod()
        {
            InitializeComponent();
        }

        private void PeriodRG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (periodRG.SelectedIndex >= 0)
            {
                if (!string.IsNullOrWhiteSpace(periodRG.Properties.Items[periodRG.SelectedIndex].Description))
                {
                    Period = (EPeriod)Enum.Parse(typeof(EPeriod), periodRG.Properties.Items[periodRG.SelectedIndex].Description);
                }
            }

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
