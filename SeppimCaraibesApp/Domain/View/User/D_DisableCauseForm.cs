namespace SeppimCaraibesApp.Domain.View.User
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class D_DisableCauseForm : Form
    {
        private const string MESSAGE = "Debe especificar la causa.";

        private readonly C_User _cUser;

        public string cause;


        #region Ctor
        public D_DisableCauseForm()
        {
            InitializeComponent();

            _cUser = new C_User();
            cause = string.Empty;
        }

        public D_DisableCauseForm(C_User cUser)
        {
            InitializeComponent();

            _cUser = cUser;
            cause = string.Empty;
        }
        #endregion


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

                C_Log _cLog = new C_Log();
                _cLog.Write("La ventana se cerrará.", ETypeOfMessage.Information);

                Close();
            }
        }
    }
}
