﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeppimCaraibesApp
{
    public partial class V_MainForm : Form
    {
        public V_MainForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var listCustomer = new Domain.View.Customer.V_ListCustomersForm
            {
                TopLevel = false
            };
            panelControl1.Controls.Add(listCustomer);
            listCustomer.Dock = DockStyle.Fill;
            listCustomer.BringToFront();
            listCustomer.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var listProvider = new Domain.View.Provider.V_ListProvidersForm
            {
                TopLevel = false
            };
            panelControl1.Controls.Add(listProvider);
            listProvider.Dock = DockStyle.Fill;
            listProvider.BringToFront();
            listProvider.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var listProduct = new Domain.View.Product.V_ListProductsForm
            {
                TopLevel = false
            };
            panelControl1.Controls.Add(listProduct);
            listProduct.Dock = DockStyle.Fill;
            listProduct.BringToFront();
            listProduct.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var listPreOrder = new Domain.View.Order.V_ListPreOrdersForm
            {
                TopLevel = false
            };
            panelControl1.Controls.Add(listPreOrder);
            listPreOrder.Dock = DockStyle.Fill;
            listPreOrder.BringToFront();
            listPreOrder.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var listQuotes = new Domain.View.Order.V_ListQuotesForm
            {
                TopLevel = false
            };
            panelControl1.Controls.Add(listQuotes);
            listQuotes.Dock = DockStyle.Fill;
            listQuotes.BringToFront();
            listQuotes.Show();
        }

        private void SimpleButton6_Click(object sender, EventArgs e)
        {
            var listOrders = new Domain.View.Order.V_ListOrdersForm
            {
                TopLevel = false
            };
            panelControl1.Controls.Add(listOrders);
            listOrders.Dock = DockStyle.Fill;
            listOrders.BringToFront();
            listOrders.Show();
        }
    }
}
