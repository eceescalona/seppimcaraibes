namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditQuoteForm : Form, IAddEditOrder
    {
        private const string NAME_FORM_EDIT = "Editar Oferta";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Order _cOrder;
        private readonly C_Product _cProduct;
        private bool _isCOrderAlive;
        private bool _isFieldWithError;


        public V_AddEditQuoteForm(C_Order cOrder, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            providerReferenceTE.Select();

            _cOrder = cOrder;
            _cProduct = new C_Product(_cOrder.GetContext());
            _isCOrderAlive = true;
            _isFieldWithError = false;

            _cOrder.EditOrder(this, code);

            productsBS.DataSource = _cProduct.FillProductsOrders();
            shipmentBS.DataSource = new Data.ORM.Shipment();
        }


        private void V_AddEditQuoteForm_Load(object sender, EventArgs e)
        {
            InitializeLUE();
        }

        private void ProductsGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var order = (Data.ORM.Order)orderBS.Current;

            if (order != null && (order.ProductsOrders != null && order.ProductsOrders.Count > 0))
            {
                foreach (var product in order.ProductsOrders)
                {
                    if (productsGV.GetRow(e.RowHandle) is Data.POCO.ProductsOrders row)
                    {
                        if (row.ProductId == product.ProductId)
                        {
                            row.Qty = product.Qty;
                            row.SalePrice = product.Discount;
                            productsGV.SelectRow(e.RowHandle);
                        }
                    }
                }

                e.HighPriority = true;
            }
        }

        private void InitializeLUE()
        {
            paymentOptionsBS.DataSource = typeof(EPaymentOption);
            var tempEPO = Enum.GetValues(typeof(EPaymentOption));
            paymentOptionsBS.Clear();
            paymentOptionsBS.DataSource = tempEPO;
            paymentOptionLUE.Properties.DataSource = paymentOptionsBS.List;

            deviseBS.DataSource = typeof(EDevise);
            var tempEDevise = Enum.GetValues(typeof(EDevise));
            deviseBS.Clear();
            deviseBS.DataSource = tempEDevise;
            deviseLUE.Properties.DataSource = deviseBS.List;

            shipmentMethodBS.DataSource = typeof(EShippingMethod);
            var tempESM = Enum.GetValues(typeof(EShippingMethod));
            shipmentMethodBS.Clear();
            shipmentMethodBS.DataSource = tempESM;
            shipmentMLUE.Properties.DataSource = shipmentMethodBS.List;

            incotermsBS.DataSource = typeof(EIncoterms);
            var tempEI = Enum.GetValues(typeof(EIncoterms));
            incotermsBS.Clear();
            incotermsBS.DataSource = tempEI;
            eIncotermLUE.Properties.DataSource = incotermsBS.List;
        }


        #region IAddEditOrder
        public void EditOrder(Data.ORM.Order order)
        {
            orderBS.DataSource = order;

            if (order.Shipment != null)
            {
                shipmentBS.Clear();
                shipmentBS.DataSource = order.Shipment;
                shipmentMLUE.EditValue = order.Shipment.ShippingMethod;
            }

            if (order.Devise != null)
            {
                deviseLUE.EditValue = order.Devise;
            }

            if (order.PaymentOption != null)
            {
                paymentOptionLUE.EditValue = order.PaymentOption;
            }

            if (order.IncotermType != null)
            {
                eIncotermLUE.EditValue = order.IncotermType;
            }

            if (order.ExpensesType != null)
            {
                if (order.ExpensesType == EExpenses.FCA)
                {
                    expensesTypeRG.SelectedIndex = 0;
                }
                else
                {
                    expensesTypeRG.SelectedIndex = 1;
                }
            }
        }

        public void RefreshView()
        {
            providerReferenceTE.Text = string.Empty;
            initDateDE.DateTime = DateTime.Now;
            endDateDE.DateTime = DateTime.Now;
            totalCostTE.Text = string.Empty;
            grossWTE.Text = string.Empty;
            netWTE.Text = string.Empty;
            placeDME.Text = string.Empty;
            inspectionTE.Text = string.Empty;

            providerRErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            providerRErrorLC.Text = string.Empty;
            providerRErrorLC.LineColor = Color.Black;
            providerRErrorLC.ForeColor = Color.Black;

            productsBS.ResetBindings(true);
            productsBS.DataSource = _cProduct.FillProductsOrders();
            deviseLUE.EditValue = null;
            paymentOptionLUE.EditValue = null;
            shipmentMLUE.EditValue = null;
            eIncotermLUE.EditValue = null;
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
                var order = (Data.ORM.Order)orderBS.Current;

                var products = new List<Data.POCO.ProductsOrders>();

                int[] indexsProducts = productsGV.GetSelectedRows();

                for (int i = 0; i < indexsProducts.Length; i++)
                {
                    if (indexsProducts[i] != -1)
                    {
                        products.Add((Data.POCO.ProductsOrders)productsGV.GetRow(indexsProducts[i]));
                    }
                }

                if (!string.IsNullOrWhiteSpace(paymentOptionLUE.Text))
                {
                    order.PaymentOption = (EPaymentOption)Enum.Parse(typeof(EPaymentOption), paymentOptionLUE.Text);
                }

                if (!string.IsNullOrWhiteSpace(deviseLUE.Text))
                {
                    order.Devise = (EDevise)Enum.Parse(typeof(EDevise), deviseLUE.Text);
                }

                if (!string.IsNullOrWhiteSpace(eIncotermLUE.Text))
                {
                    order.IncotermType = (EIncoterms)Enum.Parse(typeof(EIncoterms), eIncotermLUE.Text);
                }

                if (expensesTypeRG.SelectedIndex >= 0)
                {
                    if (!string.IsNullOrWhiteSpace(expensesTypeRG.Properties.Items[expensesTypeRG.SelectedIndex].Description))
                    {
                        order.ExpensesType = (EExpenses)Enum.Parse(typeof(EExpenses), expensesTypeRG.Properties.Items[expensesTypeRG.SelectedIndex].Description);
                    }
                }

                var shipment = (Data.ORM.Shipment)shipmentBS.Current;

                if (!string.IsNullOrWhiteSpace(shipmentMLUE.Text))
                {
                    shipment.ShippingMethod = (EShippingMethod)Enum.Parse(typeof(EShippingMethod), shipmentMLUE.Text);
                }

                order.Shipment = shipment;

                order.EXW = products.Sum(po => po.SalePrice * po.Qty);

                double.TryParse(expensesTE.Text, out double expenses);

                double EXW = decimal.ToDouble(order.EXW == null ? 0 : (decimal)order.EXW);
                double TotalDiscount = order.TotalDiscount == null ? 0 : (double)order.TotalDiscount * EXW / 100;
                double Freight = decimal.ToDouble(order.Freight == null ? 0 : (decimal)order.Freight);
                double Insurance = decimal.ToDouble(order.Insurance == null ? 0 : (decimal)order.Insurance);
                double ToltalInterests = order.ToltalInterests == null ? 0 : (double)order.ToltalInterests / 36000 * (int)order.Period * EXW;

                order.TotalCost = EXW - TotalDiscount + expenses + Freight + Insurance + ToltalInterests;

                if (order.BigingDate != null && order.EndDate != null)
                {
                    order.OfferPeriod = (order.BigingDate - order.EndDate).Value.Days;
                }

                _cOrder.EditOrder(this, order, products);

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

            C_Log _cLog = new C_Log();
            _cLog.Write(CLOSE_MESSAGE, ETypeOfMessage.Information);

            DialogResult = DialogResult.OK;
            Close();
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
