namespace SeppimCaraibesApp
{
    using System;
    using System.Windows.Forms;

    internal partial class V_MainForm : Form
    {
        private readonly Domain.Controller.C_User _cUser;


        #region Ctor
        public V_MainForm()
        {
            InitializeComponent();
        }

        public V_MainForm(Domain.Controller.C_User cUser)
        {
            InitializeComponent();
            _cUser = cUser;
        }
        #endregion


        #region Menu
        private void CustomersACE_Click(object sender, EventArgs e)
        {
            var listCustomer = new Domain.View.Customer.V_ListCustomersForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listCustomer);
            listCustomer.Dock = DockStyle.Fill;
            listCustomer.BringToFront();
            listCustomer.Show();
        }

        private void ProvidersACE_Click(object sender, EventArgs e)
        {
            var listProvider = new Domain.View.Provider.V_ListProvidersForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listProvider);
            listProvider.Dock = DockStyle.Fill;
            listProvider.BringToFront();
            listProvider.Show();
        }

        private void ProductsACE_Click(object sender, EventArgs e)
        {
            var listProduct = new Domain.View.Product.V_ListProductsForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listProduct);
            listProduct.Dock = DockStyle.Fill;
            listProduct.BringToFront();
            listProduct.Show();
        }

        private void PreOrdersACE_Click(object sender, EventArgs e)
        {
            var listPreOrder = new Domain.View.Order.V_ListPreOrdersForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listPreOrder);
            listPreOrder.Dock = DockStyle.Fill;
            listPreOrder.BringToFront();
            listPreOrder.Show();

            preOrdersACE.AccordionControl.Focus();
        }

        private void QuotesACE_Click(object sender, EventArgs e)
        {
            var listQuotes = new Domain.View.Order.V_ListQuotesForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listQuotes);
            listQuotes.Dock = DockStyle.Fill;
            listQuotes.BringToFront();
            listQuotes.Show();

            quotesACE.AccordionControl.Focus();
        }

        private void OrdersOACE_Click(object sender, EventArgs e)
        {
            var listOrders = new Domain.View.Order.V_ListOrdersForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listOrders);
            listOrders.Dock = DockStyle.Fill;
            listOrders.BringToFront();
            listOrders.Show();

            ordersOACE.AccordionControl.Focus();
        }

        private void InvoicesACE_Click(object sender, EventArgs e)
        {
            var listInvoices = new Domain.View.Invoice.V_ListInvoicesForm
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listInvoices);
            listInvoices.Dock = DockStyle.Fill;
            listInvoices.BringToFront();
            listInvoices.Show();
        }

        private void UsersACE_Click(object sender, EventArgs e)
        {
            var listUsers = new Domain.View.User.V_ListUsersForm(_cUser)
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listUsers);
            listUsers.Dock = DockStyle.Fill;
            listUsers.BringToFront();
            listUsers.Show();
        }

        private void RolesACE_Click(object sender, EventArgs e)
        {
            var listRoles = new Domain.View.Role.V_ListRolesForm(_cUser)
            {
                TopLevel = false
            };
            viewsPC.Controls.Add(listRoles);
            listRoles.Dock = DockStyle.Fill;
            listRoles.BringToFront();
            listRoles.Show();
        }
        #endregion


        private void V_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cUser.LogOff((Domain.Controller.IControlUser)Owner);
            Dispose();
            Close();
        }
    }
}
