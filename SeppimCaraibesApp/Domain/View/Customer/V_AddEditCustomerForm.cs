﻿namespace SeppimCaraibesApp.Domain.View.Customer
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditCustomerForm : Form, IAddEditCustomer
    {
        private const string CALL_FROM_ORDERS = "PreOrder";
        private const string NAME_FORM_ADD = "Registrar Cliente";
        private const string NAME_FORM_EDIT = "Editar Cliente";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Customer _cCustomer;
        private bool _isCCustomerAlive;
        private readonly string _whereFrom;
        private readonly bool _isAddOrEdit;
        private bool _isFieldWithError;
        public string code;


        #region Ctor
        public V_AddEditCustomerForm()
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cCustomer = new C_Customer();
            _isCCustomerAlive = true;
            _whereFrom = CALL_FROM_ORDERS;
            _isAddOrEdit = false;
            _isFieldWithError = false;

            customerBS.DataSource = new Data.ORM.Customer();
        }

        public V_AddEditCustomerForm(C_Customer cCustomer)
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cCustomer = cCustomer;
            _isCCustomerAlive = true;
            _whereFrom = string.Empty;
            _isAddOrEdit = false;
            _isFieldWithError = false;

            customerBS.DataSource = new Data.ORM.Customer();
        }

        public V_AddEditCustomerForm(C_Customer cCustomer, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cCustomer = cCustomer;
            _isCCustomerAlive = true;
            this.code = code;
            _whereFrom = string.Empty;
            _isAddOrEdit = true;
            _isFieldWithError = false;

            _cCustomer.EditCustomer(this, code);
        }
        #endregion


        private void V_AddEditCustomerForm_Load(object sender, EventArgs e)
        {
            if (_isAddOrEdit)
            {
                nameTE.Focus();
                codeTE.Enabled = false;
            }
            else
            {
                codeTE.Focus();
            }
        }


        #region IAddEditCustomer
        public void EditCustomer(Data.ORM.Customer customer)
        {
            customerBS.DataSource = customer;
        }

        public void RefreshView()
        {
            codeTE.Text = string.Empty;
            nameTE.Text = string.Empty;
            phoneTE.Text = string.Empty;
            emailTE.Text = string.Empty;
            addressTE.Text = string.Empty;

            codeErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            codeErrorLC.Text = string.Empty;
            codeErrorLC.LineColor = Color.Black;
            codeErrorLC.ForeColor = Color.Black;

            nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            nameErrorLC.Text = string.Empty;
            nameErrorLC.LineColor = Color.Black;
            nameErrorLC.ForeColor = Color.Black;

            emailErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            emailErrorLC.Text = string.Empty;
            emailErrorLC.LineColor = Color.Black;
            emailErrorLC.ForeColor = Color.Black;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (codeTE.Name == field.Key)
                    {
                        codeErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        codeErrorLC.Text = field.Value;
                        codeErrorLC.LineColor = Color.Red;
                        codeErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (nameTE.Name == field.Key)
                    {
                        nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        nameErrorLC.Text = field.Value;
                        nameErrorLC.LineColor = Color.Red;
                        nameErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        emailErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        emailErrorLC.Text = field.Value;
                        emailErrorLC.LineColor = Color.Red;
                        emailErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (codeTE.Name == fields.First().Key)
                {
                    codeTE.Focus();
                }
                else if (nameTE.Name == fields.First().Key)
                {
                    nameTE.Focus();
                }
                else
                {
                    emailTE.Focus();
                }
            }
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cCustomer.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cCustomer.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cCustomer.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region ActionsButtons
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = (Data.ORM.Customer)customerBS.Current;

                if (_isAddOrEdit)
                {
                    _cCustomer.EditCustomer(this, customer);
                    _isCCustomerAlive = true;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    _cCustomer.AddCustomer(this, customer);

                    if (!string.IsNullOrWhiteSpace(_whereFrom))
                    {
                        _isCCustomerAlive = false;
                        code = customer.CustomerId;
                        DialogResult = DialogResult.OK;
                        Close();
                    }

                    if (!_isFieldWithError)
                    {
                        RefreshView();
                        _isFieldWithError = false;
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cCustomer.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);

                if (result == DialogResult.Retry)
                {
                    acceptSB.Click += AcceptSB_Click;
                }
                else if (result == DialogResult.Abort)
                {
                    if (_isAddOrEdit)
                    {
                        _isCCustomerAlive = true;
                        DialogResult = DialogResult.Abort;
                        Close();
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(_whereFrom))
                        {
                            code = string.Empty;
                            _isCCustomerAlive = false;
                            DialogResult = DialogResult.Abort;
                            Close();
                        }
                        else
                        {
                            _isCCustomerAlive = true;
                            DialogResult = DialogResult.Abort;
                            Close();
                        }
                    }
                }
                else
                {
                    RefreshView();
                }
            }
        }

        private void CancelSB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cCustomer.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_isAddOrEdit)
            {
                if (result == DialogResult.Yes)
                {
                    _isCCustomerAlive = true;
                    DialogResult = DialogResult.Cancel;

                    C_Log _cLog = new C_Log();
                    _cLog.Write(CANCEL_MESSAGE, ETypeOfMessage.Information);

                    RefreshView();
                }
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(_whereFrom))
                    {
                        _isCCustomerAlive = true;
                        DialogResult = DialogResult.Cancel;

                        C_Log _cLog = new C_Log();
                        _cLog.Write(CANCEL_MESSAGE, ETypeOfMessage.Information);

                        RefreshView();
                    }
                    else
                    {
                        _isCCustomerAlive = false;
                        DialogResult = DialogResult.Cancel;

                        C_Log _cLog = new C_Log();
                        _cLog.Write(CANCEL_MESSAGE, ETypeOfMessage.Information);

                        RefreshView();
                    }
                }
            }
        }

        private void CloseSB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CLOSE_MESSAGE, _cCustomer.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            C_Log _cLog = new C_Log();
            _cLog.Write(CLOSE_MESSAGE, ETypeOfMessage.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion


        private void V_AddEditCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCCustomerAlive)
                Dispose();
            else
            {
                _cCustomer.Dispose();
                Dispose();
            }
        }
    }
}
