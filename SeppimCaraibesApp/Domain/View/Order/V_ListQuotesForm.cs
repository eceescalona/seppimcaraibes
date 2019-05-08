using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeppimCaraibesApp.Domain.View.Order
{
    public partial class V_ListQuotesForm : Form
    {
        public V_ListQuotesForm()
        {
            InitializeComponent();
        }

        private void V_ListQuotesForm_Load(object sender, EventArgs e)
        {
            quotesEIFS.GetQueryable += QuotesEIFS_GetQueryable;
        }

        void QuotesEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = new Data.ORM.SeppimCaraibesLocalEntities();
            e.QueryableSource = dataContext.QuotesViews;
        }


        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void V_ListQuotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
