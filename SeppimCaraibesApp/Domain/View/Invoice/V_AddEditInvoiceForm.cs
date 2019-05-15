namespace SeppimCaraibesApp.Domain.View.Invoice
{
    using System.Windows.Forms;

    internal partial class V_AddEditInvoiceForm : Form
    {
        public V_AddEditInvoiceForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            banksEIFS.GetQueryable += BanksEIFS_GetQueryable;
        }

        void BanksEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = new SeppimCaraibesApp.Data.ORM.SeppimCaraibesLocalEntities();
            e.QueryableSource = dataContext.Banks;
        }
    }
}
