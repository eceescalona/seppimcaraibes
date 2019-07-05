namespace SeppimCaraibesApp.Domain.View.User
{
    using System;
    using System.Windows.Forms;

    internal partial class D_DisableCauseForm : Form
    {
        private const string MESSAGE = "Debe especificar la causa.";

        private readonly Controller.C_User _cUser;

        public string cause;


        public D_DisableCauseForm()
        {
            InitializeComponent();

            _cUser = new Controller.C_User();
            cause = string.Empty;
        }

        public D_DisableCauseForm(Controller.C_User cUser)
        {
            InitializeComponent();

            _cUser = cUser;
            cause = string.Empty;
        }

        private void AcceptSB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(disableCauseME.Text))
            {
                MessageBox.Show(MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cause = disableCauseME.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
