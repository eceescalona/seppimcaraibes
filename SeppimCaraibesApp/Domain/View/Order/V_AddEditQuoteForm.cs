namespace SeppimCaraibesApp.Domain.View.Order
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

    internal partial class V_AddEditQuoteForm : Form, Controller.IAddEditOrder
    {
        private const string CANCEL_ADD_CUSTOMER_MESSAGE = "La operación ha sido cancelada.";
        private const string NAME_FORM_EDIT = "Editar Cotización";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private Controller.C_Order _cOrder;
        private Controller.C_Product _cProduct;
        private bool _isCOrderAlive;
        private bool _isFieldWithError;


        public V_AddEditQuoteForm(Controller.C_Order cOrder, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cOrder = cOrder;
            _cProduct = new Controller.C_Product(_cOrder.GetContext());
            _isCOrderAlive = true;
            _isFieldWithError = false;

            _cOrder.EditOrder(this, code);

            productsBS.DataSource = _cProduct.FillProductsOrders();
        }


        private void V_AddEditQuoteForm_Load(object sender, EventArgs e)
        {
            InitializeLUE();
        }

        private void ProductsGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var order = (Data.ORM.Order)orderBS.Current;
            foreach (var product in order.ProductsOrders)
            {
                if (productsGV.GetRow(e.RowHandle) is Data.POCO.ProductsOrders row)
                {
                    if (row.ProductId == product.ProductId)
                    {
                        row.Qty = product.Qty;
                        productsGV.SelectRow(e.RowHandle);
                    }
                }
            }

            e.HighPriority = true;
        }

        private void InitializeLUE()
        {
            paymentOptionsBS.DataSource = typeof(EPaymentOption);
            paymentOptionLUE.Properties.DataSource = paymentOptionsBS.List;

            deviseBS.DataSource = typeof(EDevise);
            deviseLUE.Properties.DataSource = deviseBS.List;

            shipmentMethodBS.DataSource = typeof(EShippingMethod);
            shipmentMLUE.Properties.DataSource = shipmentMethodBS.List;
        }


        #region IAddEditOrder
        public void EditOrder(Data.ORM.Order order)
        {
            orderBS.DataSource = order;
            if (order.Shipment != null)
            {
                shipmentMLUE.EditValue = order.Shipment.ShippingMethod;

            }

            if (order.Devise != 0)
            {
                deviseLUE.EditValue = order.Devise;
            }

            if (order.PaymentOption != 0)
            {
                paymentOptionLUE.EditValue = order.PaymentOption;
            }
        }

        public void RefreshView()
        {
            providerReferenceTE.Text = string.Empty;
            offerPeriodTE.Text = string.Empty;
            incotermTE.Text = string.Empty;
            totalCostTE.Text = string.Empty;
            grossWTE.Text = string.Empty;
            netWTE.Text = string.Empty;
            packingTE.Text = string.Empty;
            placeDTE.Text = string.Empty;

            providerRErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            providerRErrorLC.Text = string.Empty;
            providerRErrorLC.LineColor = Color.Black;
            providerRErrorLC.ForeColor = Color.Black;

            productsBS.ResetBindings(true);
            productsBS.DataSource = _cProduct.FillProductsOrders();
            deviseLUE.EditValue = null;
            paymentOptionLUE.EditValue = null;
            shipmentMLUE.EditValue = null;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (providerReferenceTE.Name == field.Key)
                    {
                        providerRErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        providerRErrorLC.Text = field.Value;
                        providerRErrorLC.LineColor = Color.Red;
                        providerRErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (providerReferenceTE.Name == fields.First().Key)
                {
                    providerReferenceTE.Focus();
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
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var products = new List<Data.POCO.ProductsOrders>();

                int[] indexsProducts = productsGV.GetSelectedRows();

                for (int i = 0; i < indexsProducts.Length; i++)
                {
                    if (indexsProducts[i] != -1)
                    {
                        products.Add((Data.POCO.ProductsOrders)productsGV.GetRow(indexsProducts[i]));
                    }
                }

                var order = (Data.ORM.Order)orderBS.Current;

                _cOrder.EditOrder(this, order, products);

                if (!_isFieldWithError)
                {
                    RefreshView();
                    _isFieldWithError = false;
                }

                DialogResult = DialogResult.OK;
                Close();


            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cProduct.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
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
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _isCOrderAlive = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        #endregion


        private void V_AddEditQuoteForm_FormClosed(object sender, FormClosedEventArgs e)
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
