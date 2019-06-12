namespace SeppimCaraibesApp.Domain.View.Bank
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditBankForm : Form, Controller.IAddEditBank
    {
        private const string NAME_FORM_ADD = "Registrar Banco";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private readonly Controller.C_Bank _cBank;
        private bool _isCBankAlive;
        private bool _isFieldWithError;
        public int code;


        public V_AddEditBankForm()
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cBank = new Controller.C_Bank();
            _isCBankAlive = true;
            _isFieldWithError = false;

            bankBS.DataSource = new Data.ORM.Bank();
        }


        #region IAddEditBank
        public void RefreshView()
        {
            nameTE.Text = string.Empty;
            accountNumberTE.Text = string.Empty;
            accountNameTE.Text = string.Empty;
            addressTE.Text = string.Empty;
            swiftTE.Text = string.Empty;

            nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            nameErrorLC.Text = string.Empty;
            nameErrorLC.LineColor = Color.Black;
            nameErrorLC.ForeColor = Color.Black;

            addressErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            addressErrorLC.Text = string.Empty;
            addressErrorLC.LineColor = Color.Black;
            addressErrorLC.ForeColor = Color.Black;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (nameTE.Name == field.Key)
                    {
                        nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        nameErrorLC.Text = field.Value;
                        nameErrorLC.LineColor = Color.Red;
                        nameErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        addressErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        addressErrorLC.Text = field.Value;
                        addressErrorLC.LineColor = Color.Red;
                        addressErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (nameTE.Name == fields.First().Key)
                {
                    nameTE.Focus();
                }
                else
                {
                    addressTE.Focus();
                }
            }
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cBank.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cBank.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cBank.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region ActionsButtons
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var bank = (Data.ORM.Bank)bankBS.Current;

                _cBank.AddBank(this, bank, out int idBank);

                if (!_isFieldWithError)
                {
                    RefreshView();
                    _isFieldWithError = false;
                }
                else
                {
                    code = idBank;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cBank.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    acceptSB.Click += AcceptSB_Click;
                }
                else if (result == DialogResult.Abort)
                {
                    DialogResult = DialogResult.Abort;
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
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cBank.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _isCBankAlive = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        #endregion


        private void V_AddEditBankForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCBankAlive)
            {
                _cBank.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
