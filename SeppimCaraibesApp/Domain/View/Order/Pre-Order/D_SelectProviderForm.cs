namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class D_SelectProviderForm : Form, ISelectProvider
    {
        private const string NAME = "Seleccionar Proveedor";
        private const string LABEL_MESSAGE_PROVEEDOR = "Debe seleccionar un proveedor";

        private readonly C_Order _cOrder;
        private readonly bool _isCOrderAlive;
        private bool _isFieldWithError;
        private readonly string _code;


        public D_SelectProviderForm(C_Order cOrder, string code)
        {
            InitializeComponent();
            _cOrder = cOrder;
            _code = code;

            Text = NAME;

            _isCOrderAlive = true;
            _isFieldWithError = false;
            providerEIFS.GetQueryable += ProviderEIFS_GetQueryable;
        }


        void ProviderEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cOrder.GetContext();
            e.QueryableSource = dataContext.Providers;
        }


        #region ISelectProvider
        public void RefreshView()
        {
            messageLC.LookAndFeel.UseDefaultLookAndFeel = false;
            messageLC.Text = LABEL_MESSAGE_PROVEEDOR;
            messageLC.LineColor = Color.Black;
            messageLC.ForeColor = Color.Black;
        }

        public void ShowFieldsWithError(string field, string message)
        {
            if (!string.IsNullOrWhiteSpace(field))
            {
                if (providerSLUE.Name == field)
                {
                    messageLC.LookAndFeel.UseDefaultLookAndFeel = false;
                    messageLC.Text = message;
                    messageLC.LineColor = Color.Red;
                    messageLC.ForeColor = Color.Red;

                    _isFieldWithError = true;
                }

                if (providerSLUE.Name == field)
                {
                    providerSLUE.Focus();
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


        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var provider = (Data.ORM.Provider)providerLUEV.GetFocusedRow();
                _cOrder.SetProviderOrder(this, _code, provider);
                DialogResult = DialogResult.OK;
                if (!_isFieldWithError)
                {
                    RefreshView();
                    _isFieldWithError = false;
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }


        private void D_SelectProviderForm_FormClosed(object sender, FormClosedEventArgs e)
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
