namespace SeppimCaraibesApp.Domain.View
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class U_LogginPage : Form, Controller.IControlUser
    {
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre la aplicación y " +
            "vuelva a abrirla. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "¿Desea salir?";

        private readonly Controller.C_User _cUser;
        private bool _isFieldWithError;


        public U_LogginPage()
        {
            InitializeComponent();
            _cUser = new Controller.C_User();
            _isFieldWithError = false;
        }


        #region IControlUser
        public void DisplayMain(Data.ORM.User user)
        {
            var main = new V_MainForm();
            main.BringToFront();
            main.Show();
            Hide();
        }

        public void RefreshView()
        {
            nickTE.Text = string.Empty;
            passwordTE.Text = string.Empty;

            nickErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            nickErrorLC.Text = string.Empty;
            nickErrorLC.LineColor = Color.Black;
            nickErrorLC.ForeColor = Color.Black;

            passwordErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            passwordErrorLC.Text = string.Empty;
            passwordErrorLC.LineColor = Color.Black;
            passwordErrorLC.ForeColor = Color.Black;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (nickTE.Name == field.Key)
                    {
                        nickErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        nickErrorLC.Text = field.Value;
                        nickErrorLC.LineColor = Color.Red;
                        nickErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        passwordErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        passwordErrorLC.Text = field.Value;
                        passwordErrorLC.LineColor = Color.Red;
                        passwordErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (nickTE.Name == fields.First().Key)
                {
                    nickTE.Focus();
                }
                else
                {
                    passwordTE.Focus();
                }
            }
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cUser.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cUser.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cUser.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region ActionsButtons
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                _cUser.Loggin(this, nickTE.Text, passwordTE.Text);

                if (!_isFieldWithError)
                {
                    RefreshView();
                    _isFieldWithError = false;
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cUser.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    acceptSB.Click += AcceptSB_Click;
                }
                else if (result == DialogResult.Abort)
                {
                    Close();
                }
                else
                {
                    RefreshView();
                }
            }
        }

        private void CancelSB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                RefreshView();
            }
        }
        #endregion


        private void U_LogginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cUser.Dispose();
            Application.Exit();
        }
    }
}
