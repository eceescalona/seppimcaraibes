namespace SeppimCaraibesApp.Domain.View.Order
{
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditPreOrderForm : Form, IAddEditOrder
    {
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo cliente. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string LABEL_MESSAGE_PRODUCT = "Debe seleccionar al menos un producto";
        private const string LABEL_MESSAGE_CUSTOMER = "Debe seleccionar un cliente";
        private const string NAME_FORM_ADD = "Registrar Pre-Orden";
        private const string NAME_FORM_EDIT = "Editar Pre-Orden";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Order _cOrder;
        private readonly C_Product _cProduct;
        private bool _isCOrderAlive;
        private readonly bool _isAddOrEdit;
        private bool _isFieldWithError;
        private string _idCustomer;


        #region Ctor
        public V_AddEditPreOrderForm()
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cOrder = new C_Order();
            _cProduct = new C_Product(_cOrder.GetContext());
            _isCOrderAlive = true;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idCustomer = string.Empty;

            customerEIFS.GetQueryable += CustomerEIFS_GetQueryable;
            orderBS.DataSource = new Data.ORM.Order();
        }

        public V_AddEditPreOrderForm(C_Order cOrder)
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cOrder = cOrder;
            _cProduct = new C_Product(_cOrder.GetContext());
            _isCOrderAlive = true;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idCustomer = string.Empty;

            customerEIFS.GetQueryable += CustomerEIFS_GetQueryable;
            orderBS.DataSource = new Data.ORM.Order();
            shipmentBS.DataSource = new Data.ORM.Shipment();
        }

        public V_AddEditPreOrderForm(C_Order cOrder, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cOrder = cOrder;
            _cProduct = new C_Product(_cOrder.GetContext());
            _isCOrderAlive = true;
            _isAddOrEdit = true;
            _isFieldWithError = false;
            _idCustomer = string.Empty;

            _cOrder.EditOrder(this, code);

            customerEIFS.GetQueryable += CustomerEIFS_GetQueryable;
            shipmentBS.DataSource = new Data.ORM.Shipment();
        }
        #endregion


        private void V_AddEditPreOrderForm_Load(object sender, EventArgs e)
        {
            productsBS.DataSource = _cProduct.FillProductsOrders();

            InitializeLUE();

            if (_isAddOrEdit)
            {
                customerSLUE.Enabled = false;
                addCustomerSB.Enabled = false;
            }
        }

        private void CustomerEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cOrder.GetContext();
            e.QueryableSource = dataContext.Customers;
        }

        private void ProductsGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (_isAddOrEdit)
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
        }

        private void CustomerSLUEV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (_isAddOrEdit)
            {
                var order = (Data.ORM.Order)orderBS.Current;
                if (customerSLUEV.GetRow(e.RowHandle) is Data.ORM.Customer row)
                {
                    if (row.CustomerId == order.CustomerId)
                    {
                        customerSLUEV.SelectRow(e.RowHandle);
                    }
                }
            }

            e.HighPriority = true;
        }

        private void InitializeLUE()
        {
            paymentOptionsBS.DataSource = typeof(EPaymentOption);
            var tempEPO = Enum.GetValues(typeof(EPaymentOption));
            paymentOptionsBS.Clear();
            paymentOptionsBS.DataSource = tempEPO;
            paymentOptionLUE.Properties.DataSource = paymentOptionsBS.List;

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

            deviseBS.DataSource = typeof(EDevise);
            var tempEDevise = Enum.GetValues(typeof(EDevise));
            deviseBS.Clear();
            deviseBS.DataSource = tempEDevise;
            deviseLUE.Properties.DataSource = deviseBS.List;
        }


        #region IAddEditOrder
        public void EditOrder(Data.ORM.Order order)
        {
            orderBS.DataSource = order;
            _idCustomer = order.CustomerId;
            customerSLUE.EditValue = _idCustomer;

            if (order.Shipment != null)
            {
                shipmentBS.Clear();
                shipmentBS.DataSource = order.Shipment;
                shipmentMLUE.EditValue = order.Shipment.ShippingMethod;
            }

            if (order.PaymentOption != null)
            {
                paymentOptionLUE.EditValue = order.PaymentOption;
            }

            if (order.IncotermType != null)
            {
                eIncotermLUE.EditValue = order.IncotermType;
            }

            if (order.Devise != null)
            {
                deviseLUE.EditValue = order.Devise;
            }
        }

        public void RefreshView()
        {
            dateDE.DateTime = DateTime.Now;
            customerReferenceTE.Text = string.Empty;

            dateErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            dateErrorLC.Text = string.Empty;
            dateErrorLC.LineColor = Color.Black;
            dateErrorLC.ForeColor = Color.Black;

            customerReferenceErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            customerReferenceErrorLC.Text = string.Empty;
            customerReferenceErrorLC.LineColor = Color.Black;
            customerReferenceErrorLC.ForeColor = Color.Black;

            customerErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            customerErrorLC.Text = LABEL_MESSAGE_CUSTOMER;
            customerErrorLC.LineColor = Color.Black;
            customerErrorLC.ForeColor = Color.Black;

            productsErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            productsErrorLC.Text = LABEL_MESSAGE_PRODUCT;
            productsErrorLC.LineColor = Color.Black;
            productsErrorLC.ForeColor = Color.Black;

            customerSLUE.EditValue = null;
            customerEIFS.Refresh();
            customerEIFS.GetQueryable += CustomerEIFS_GetQueryable;
            orderBS.ResetBindings(true);
            orderBS.DataSource = new Data.ORM.Order();
            productsBS.ResetBindings(true);
            productsBS.DataSource = _cProduct.FillProductsOrders();

            paymentOptionLUE.EditValue = null;
            deviseLUE.EditValue = null;
            shipmentMLUE.EditValue = null;
            eIncotermLUE.EditValue = null;
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (dateDE.Name == field.Key)
                    {
                        dateErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        dateErrorLC.Text = field.Value;
                        dateErrorLC.LineColor = Color.Red;
                        dateErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (customerReferenceTE.Name == field.Key)
                    {
                        customerReferenceErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        customerReferenceErrorLC.Text = field.Value;
                        customerReferenceErrorLC.LineColor = Color.Red;
                        customerReferenceErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (productsGC.Name == field.Key)
                    {
                        productsErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        productsErrorLC.Text = field.Value;
                        productsErrorLC.LineColor = Color.Red;
                        productsErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        customerErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        customerErrorLC.Text = field.Value;
                        customerErrorLC.LineColor = Color.Red;
                        customerErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (dateDE.Name == fields.First().Key)
                {
                    dateDE.Focus();
                }
                else if (customerReferenceTE.Name == fields.First().Key)
                {
                    customerReferenceTE.Focus();
                }
                else if (productsGC.Name == fields.First().Key)
                {
                    productsGC.Focus();
                }
                else
                {
                    customerSLUE.Focus();
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
        private void AddCustomerSB_Click(object sender, EventArgs e)
        {
            try
            {
                _isCOrderAlive = true;

                using (var addCustomer = new Customer.V_AddEditCustomerForm
                {
                    StartPosition = FormStartPosition.CenterScreen
                })
                {
                    addCustomer.BringToFront();
                    DialogResult result = addCustomer.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        _idCustomer = addCustomer.code;
                        customerEIFS.Refresh();
                        customerEIFS.GetQueryable += CustomerEIFS_GetQueryable;
                        customerSLUE.EditValue = _idCustomer;
                        customerSLUE.Enabled = false;
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
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }

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

                var customer = (Data.ORM.Customer)customerSLUEV.GetFocusedRow();

                if (!string.IsNullOrWhiteSpace(paymentOptionLUE.Text))
                {
                    order.PaymentOption = (EPaymentOption)Enum.Parse(typeof(EPaymentOption), paymentOptionLUE.Text);
                }

                if (!string.IsNullOrWhiteSpace(eIncotermLUE.Text))
                {
                    order.IncotermType = (EIncoterms)Enum.Parse(typeof(EIncoterms), eIncotermLUE.Text);
                }

                if (!string.IsNullOrWhiteSpace(deviseLUE.Text))
                {
                    order.Devise = (EDevise)Enum.Parse(typeof(EDevise), deviseLUE.Text);
                }

                var shipment = (Data.ORM.Shipment)shipmentBS.Current;

                if (!string.IsNullOrWhiteSpace(shipmentMLUE.Text))
                {
                    shipment.ShippingMethod = (EShippingMethod)Enum.Parse(typeof(EShippingMethod), shipmentMLUE.Text);
                }

                order.Shipment = shipment;

                if (_isAddOrEdit)
                {
                    _cOrder.EditOrder(this, order, products);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    order.CustomerId = customer.CustomerId;
                    order.OrderState = EOrderState.InProcess;
                    order.OrderProcessState = EOrderProcessState.PreOrder;
                    _cOrder.AddOrder(this, order, products);

                    if (!_isFieldWithError)
                    {
                        RefreshView();
                        _isFieldWithError = false;
                    }
                }
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

                C_Log _cLog = new C_Log();
                _cLog.Write(CANCEL_MESSAGE, ETypeOfMessage.Information);

                DialogResult = DialogResult.Cancel;
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


        private void V_AddEditPreOrderForm_FormClosed(object sender, FormClosedEventArgs e)
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
