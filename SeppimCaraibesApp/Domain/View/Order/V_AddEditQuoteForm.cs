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
    internal partial class V_AddEditQuoteForm : Form
    {
        public V_AddEditQuoteForm()
        {
            InitializeComponent();
        }

        public V_AddEditQuoteForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
        }
    }
}
