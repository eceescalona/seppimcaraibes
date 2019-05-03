namespace SeppimCaraibesApp.Domain.View.Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal partial class V_AddEditProductForm : Form
    {
        public string code;

        public V_AddEditProductForm()
        {
            InitializeComponent();
            code = string.Empty;
        }
    }
}
