namespace SeppimCaraibesApp.Domain.View.Invoice
{
    using System.Windows.Forms;

    internal partial class V_AddEditInvoiceForm : Form
    {
        public V_AddEditInvoiceForm()
        {
            InitializeComponent();
        }

        public V_AddEditInvoiceForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
        }
    }
}
