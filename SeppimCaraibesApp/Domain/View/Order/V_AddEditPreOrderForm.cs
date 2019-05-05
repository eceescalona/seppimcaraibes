namespace SeppimCaraibesApp.Domain.View.Order
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal partial class V_AddEditPreOrderForm : Form, Controller.IAddEditOrder
    {
        private Controller.C_Order _cOrder;
        private Controller.C_Product _cProduct;

        public V_AddEditPreOrderForm()
        {
            InitializeComponent();
            _cOrder = new Controller.C_Order();
            _cProduct = new Controller.C_Product(_cOrder.GetContext());
            customerEIFS.GetQueryable += CustomerEIFS_GetQueryable;
            productsEIFS.GetQueryable += ProductEIFS_GetQueryable;
        }

        public void EditOrder(Data.ORM.Order order)
        {
            throw new NotImplementedException();
        }

        public void FillProductsOrder(DbSet<Data.ORM.ProductsOrdersView> productsOrders)
        {
            throw new NotImplementedException();
        }

        public void RefreshView()
        {
            throw new NotImplementedException();
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            throw new NotImplementedException();
        }

        void CustomerEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = new Data.ORM.SeppimCaraibesLocalEntities();
            e.QueryableSource = dataContext.Customers;
        }

        void ProductEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            e.QueryableSource = _cProduct.FillProductsOrders();
        }
    }
}
