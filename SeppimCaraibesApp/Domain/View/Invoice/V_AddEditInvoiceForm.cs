namespace SeppimCaraibesApp.Domain.View.Invoice
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditInvoiceForm : Form, Controller.IAddEditOrder
    {
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo banco. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string LABEL_MESSAGE_BANK = "Debe seleccionar un banco";
        private const string NAME_FORM_EDIT = "Editar Factura";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private readonly Controller.C_Order _cOrder;
        private bool _isCOrderAlive;
        private bool _isFieldWithError;
        private int _idBank;


        public V_AddEditInvoiceForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cOrder = cOrder;
            _isCOrderAlive = true;
            _isFieldWithError = false;
            _idBank = -1;

            _cOrder.EditOrder(this, code);

            banksEIFS.GetQueryable += BanksEIFS_GetQueryable;
        }


        private void V_AddEditInvoiceForm_Load(object sender, System.EventArgs e)
        {
            if (((Data.ORM.Order)orderBS.Current)?.BankId != null)
            {
                banksSLUE.Enabled = false;
                addBankSB.Enabled = false;
            }
        }

        private void BanksEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cOrder.GetContext();
            e.QueryableSource = dataContext.Banks;
        }

        private void BankGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var order = (Data.ORM.Order)orderBS.Current;

            if (bankGV.GetRow(e.RowHandle) is Data.ORM.Bank row)
            {
                if (row.BankId == order.BankId)
                {
                    bankGV.SelectRow(e.RowHandle);
                }
            }

            e.HighPriority = true;
        }


        #region IAddEditOrder
        public void EditOrder(Data.ORM.Order order)
        {
            orderBS.DataSource = order;
            if (order.BankId != null)
            {
                _idBank = (int)order.BankId;
                banksSLUE.EditValue = _idBank;
            }
        }

        public void RefreshView()
        {
            insuranceTE.Text = string.Empty;
            inspectionTE.Text = string.Empty;
            totalCostTE.Text = string.Empty;

            bankErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            bankErrorLC.Text = LABEL_MESSAGE_BANK;
            bankErrorLC.LineColor = Color.Black;
            bankErrorLC.ForeColor = Color.Black;

            banksSLUE.EditValue = null;
            banksEIFS.Refresh();
            banksEIFS.GetQueryable += BanksEIFS_GetQueryable;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (banksSLUE.Name == field.Key)
                    {
                        bankErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        bankErrorLC.Text = field.Value;
                        bankErrorLC.LineColor = Color.Red;
                        bankErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (banksSLUE.Name == fields.First().Key)
                {
                    banksSLUE.Focus();
                }
            }
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
        private void AddBankSB_Click(object sender, System.EventArgs e)
        {
            _isCOrderAlive = true;
            var addBank = new Bank.V_AddEditBankForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addBank.BringToFront();
            DialogResult result = addBank.ShowDialog();
            if (result == DialogResult.OK)
            {
                _idBank = addBank.code;
                banksEIFS.Refresh();
                banksEIFS.GetQueryable += BanksEIFS_GetQueryable;
                banksSLUE.EditValue = _idBank;
                banksSLUE.Enabled = false;
            }
            else if (result == DialogResult.Cancel)
            {
                RefreshView();
            }
            else
            {
                MessageBox.Show(ADD_ERROR_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcceptSB_Click(object sender, System.EventArgs e)
        {
            try
            {
                var order = (Data.ORM.Order)orderBS.Current;

                var bank = (Data.ORM.Bank)bankGV.GetFocusedRow();
                order.BankId = bank.BankId;

                order.CommercialValue = (ECommercialValue)Enum.Parse(typeof(ECommercialValue), commercialValueRG.Properties.Items[commercialValueRG.SelectedIndex].Description);

                order.InvoiceReference = _cOrder.GetInvoiceReference(order);

                _cOrder.EditOrder(this, order);


                if (!_isFieldWithError)
                {
                    RefreshView();
                    _isFieldWithError = false;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
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

        private void CancelSB_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _isCOrderAlive = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void CloseSB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uds. a terminado, la ventana cerrará.", _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion


        private void V_AddEditInvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
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
