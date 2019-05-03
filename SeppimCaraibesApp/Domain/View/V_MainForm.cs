using System;
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
    }
}
