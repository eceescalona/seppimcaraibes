using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeppimCaraibesApp.Domain.View.User
{
    internal partial class V_ListUsersForm : Form
    {
        private readonly Controller.C_User _cUser;


        public V_ListUsersForm()
        {
            InitializeComponent();
        }

        public V_ListUsersForm(Controller.C_User cUser)
        {
            InitializeComponent();

            _cUser = cUser;
        }
    }
}
