namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    internal partial class V_AddEditOrderForm : Form, IAddEditOrder
    {
        private const string NAME_FORM_EDIT = "Editar Orden Firme";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Order _cOrder;
        private bool _isCOrderAlive;
        private bool _isFieldWithError;


        public V_AddEditOrderForm(C_Order cOrder, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cOrder = cOrder;
            _isCOrderAlive = true;
            _isFieldWithError = false;

            _cOrder.EditOrder(this, code);
        }


        #region IAddEditOrder
        public void EditOrder(Data.ORM.Order order)
        {
            orderBS.DataSource = order;

            if (!string.IsNullOrWhiteSpace(order.DocRequired))
            {
                docME.Text = order.DocRequired;
            }

            if (!string.IsNullOrWhiteSpace(order.ContractDescription))
            {
                descriptionME.Text = order.ContractDescription;
            }
        }

        public void RefreshView()
        {
            docME.Text = string.Empty;
            descriptionME.Text = string.Empty;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cOrder.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cOrder.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cOrder.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region ActionsButtons
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var order = (Data.ORM.Order)orderBS.Current;

                _cOrder.EditOrder(this, order);

                if (!_isFieldWithError)
                {
                    RefreshView();
                    _isFieldWithError = false;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);

                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);

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
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _isCOrderAlive = true;
                DialogResult = DialogResult.Cancel;

                C_Log _cLog = new C_Log();
                _cLog.Write(CANCEL_MESSAGE, ETypeOfMessage.Information);

                Close();
            }
        }

        private void CloseSB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CLOSE_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DialogResult = DialogResult.OK;

            C_Log _cLog = new C_Log();
            _cLog.Write(CLOSE_MESSAGE, ETypeOfMessage.Information);

            Close();
        }
        #endregion


        private void V_AddEditOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCOrderAlive)
                Dispose();
            else
            {
                _cOrder.Dispose();
                Dispose();
            }
        }
    }
}
