namespace SeppimCaraibesApp.Domain.View.Product
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditProductForm : Form, Controller.IAddEditProduct
    {
        private const string CANCEL_ADD_PRODUCT_MESSAGE = "La operación ha sido cancelada.";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo proveedor. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string LABEL_MESSAGE_PROVIDER = "Debe elegir al menos un proveedor";
        private const string LABEL_MESSAGE_ORIGIN = "Debe elegir al menos un país";
        private const string CALL_FROM_PROVIDER = "Provider";
        private const string NAME_FORM_ADD = "Registrar Producto";
        private const string NAME_FORM_EDIT = "Editar Producto";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private readonly Controller.C_Product _cProduct;
        private bool _isCProductAlive;
        private readonly string _whereFrom;
        private readonly bool _isAddOrEdit;
        private bool _isFieldWithError;
        private string _idProvider;
        public string code;


        #region Ctor
        public V_AddEditProductForm()
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cProduct = new Controller.C_Product();
            _isCProductAlive = true;
            _whereFrom = CALL_FROM_PROVIDER;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idProvider = string.Empty;

            providersEIFS.GetQueryable += ProvidersEIFS_GetQueryable;
            originsEIFS.GetQueryable += OriginsEIFS_GetQueryable;
            productBS.DataSource = new Data.ORM.Product();
        }

        public V_AddEditProductForm(Controller.C_Product cProduct)
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cProduct = cProduct;
            _isCProductAlive = true;
            _whereFrom = string.Empty;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idProvider = string.Empty;

            providersEIFS.GetQueryable += ProvidersEIFS_GetQueryable;
            originsEIFS.GetQueryable += OriginsEIFS_GetQueryable;
            productBS.DataSource = new Data.ORM.Product();
        }

        public V_AddEditProductForm(Controller.C_Product cProduct, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cProduct = cProduct;
            _isCProductAlive = true;
            this.code = code;
            _whereFrom = string.Empty;
            _isAddOrEdit = true;
            _isFieldWithError = false;
            _idProvider = string.Empty;

            _cProduct.EditProduct(this, code);

            providersEIFS.GetQueryable += ProvidersEIFS_GetQueryable;
            originsEIFS.GetQueryable += OriginsEIFS_GetQueryable;
        }
        #endregion


        private void V_AddEditProductForm_Load(object sender, EventArgs e)
        {
            if (_isAddOrEdit)
            {
                nameME.Focus();
                codeTE.Enabled = false;
            }
            else
            {
                codeTE.Focus();
            }
        }

        void ProvidersEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cProduct.GetContext();
            e.QueryableSource = dataContext.Providers;
        }

        void OriginsEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cProduct.GetContext();
            e.QueryableSource = dataContext.Origins;
        }

        private void ProvidersGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (_isAddOrEdit)
            {
                var product = (Data.ORM.Product)productBS.Current;
                foreach (var provider in product.Providers)
                {
                    if (providersGV.GetRow(e.RowHandle) is Data.ORM.Provider row)
                    {
                        if (row.ProviderId == provider.ProviderId)
                        {
                            providersGV.SelectRow(e.RowHandle);
                        }
                    }
                }

                e.HighPriority = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_idProvider))
                {
                    if (providersGV.GetRow(e.RowHandle) is Data.ORM.Provider row)
                    {
                        if (row.ProviderId == _idProvider)
                        {
                            providersGV.SelectRow(e.RowHandle);
                        }
                    }
                }
            }
        }

        private void OriginsSLUEV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (_isAddOrEdit)
            {
                var product = (Data.ORM.Product)productBS.Current;
                foreach (var origin in product.Origins)
                {
                    if (originsSLUEV.GetRow(e.RowHandle) is Data.ORM.Origin row)
                    {
                        if (row.OriginId == origin.OriginId)
                        {
                            originsSLUEV.SelectRow(e.RowHandle);
                        }
                    }
                }

                e.HighPriority = true;
            }
        }


        #region IAddEditProduct
        public void EditProduct(Data.ORM.Product product)
        {
            productBS.DataSource = product;
        }

        public void RefreshView()
        {
            codeTE.Text = string.Empty;
            nameME.Text = string.Empty;
            descriptionME.Text = string.Empty;
            customCodeTE.Text = string.Empty;
            unitPriceTE.Text = string.Empty;
            qtyUnitsTE.Text = string.Empty;
            qtyPriceTE.Text = string.Empty;
            salePriceTE.Text = string.Empty;

            codeErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            codeErrorLC.Text = string.Empty;
            codeErrorLC.LineColor = Color.Black;
            codeErrorLC.ForeColor = Color.Black;

            nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            nameErrorLC.Text = string.Empty;
            nameErrorLC.LineColor = Color.Black;
            nameErrorLC.ForeColor = Color.Black;

            providersErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            providersErrorLC.Text = LABEL_MESSAGE_PROVIDER;
            providersErrorLC.LineColor = Color.Black;
            providersErrorLC.ForeColor = Color.Black;

            originErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            originErrorLC.Text = LABEL_MESSAGE_ORIGIN;
            originErrorLC.LineColor = Color.Black;
            originErrorLC.ForeColor = Color.Black;

            providersEIFS.Refresh();
            providersEIFS.GetQueryable += ProvidersEIFS_GetQueryable;
            originsEIFS.Refresh();
            originsEIFS.GetQueryable += OriginsEIFS_GetQueryable;
            productBS.ResetBindings(true);
            productBS.DataSource = new Data.ORM.Product();
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
                    else if (nameME.Name == field.Key)
                    {
                        nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        nameErrorLC.Text = field.Value;
                        nameErrorLC.LineColor = Color.Red;
                        nameErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (providersGridC.Name == field.Key)
                    {
                        providersErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        providersErrorLC.Text = field.Value;
                        providersErrorLC.LineColor = Color.Red;
                        providersErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        originErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        originErrorLC.Text = field.Value;
                        originErrorLC.LineColor = Color.Red;
                        originErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (codeTE.Name == fields.First().Key)
                {
                    codeTE.Focus();
                }
                else if (nameME.Name == fields.First().Key)
                {
                    nameME.Focus();
                }
                else if (providersGridC.Name == fields.First().Key)
                {
                    providersGridC.Focus();
                }
                else
                {
                    originsSLUE.Focus();
                }
            }
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cProduct.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cProduct.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cProduct.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region ActionsButtons
        private void AddProviderSP_Click(object sender, EventArgs e)
        {
            _isCProductAlive = true;
            var addProvider = new Provider.V_AddEditProviderForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addProvider.BringToFront();
            DialogResult result = addProvider.ShowDialog();
            if (result == DialogResult.OK)
            {
                _idProvider = addProvider.code;
                providersEIFS.Refresh();
                providersEIFS.GetQueryable += ProvidersEIFS_GetQueryable;
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show(CANCEL_ADD_PRODUCT_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshView();
            }
            else
            {
                MessageBox.Show(ADD_ERROR_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var providers = new List<Data.ORM.Provider>();

                int[] indexsProviders = providersGV.GetSelectedRows();

                for (int i = 0; i < indexsProviders.Length; i++)
                {
                    if (indexsProviders[i] != -1)
                    {
                        providers.Add((Data.ORM.Provider)providersGV.GetRow(indexsProviders[i]));
                    }
                }

                var origins = new List<Data.ORM.Origin>();

                int[] indexsOrigins = originsSLUEV.GetSelectedRows();

                for (int i = 0; i < indexsOrigins.Length; i++)
                {
                    if (indexsOrigins[i] != -1)
                    {
                        origins.Add((Data.ORM.Origin)originsSLUEV.GetRow(indexsOrigins[i]));
                    }
                }

                var product = (Data.ORM.Product)productBS.Current;
                product.Providers = providers;
                product.Origins = origins;

                if (_isAddOrEdit)
                {
                    _cProduct.EditProduct(this, product);
                    _isCProductAlive = true;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    _cProduct.AddProduct(this, product);

                    if (!string.IsNullOrWhiteSpace(_whereFrom))
                    {
                        _isCProductAlive = false;
                        code = product.ProductId;
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
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cProduct.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    acceptSB.Click += AcceptSB_Click;
                }
                else if (result == DialogResult.Abort)
                {
                    if (_isAddOrEdit)
                    {
                        _isCProductAlive = true;
                        DialogResult = DialogResult.Abort;
                        Close();
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(_whereFrom))
                        {
                            code = string.Empty;
                            _isCProductAlive = false;
                            DialogResult = DialogResult.Abort;
                            Close();
                        }
                        else
                        {
                            _isCProductAlive = true;
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
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_isAddOrEdit)
            {
                if (result == DialogResult.Yes)
                {
                    _isCProductAlive = true;
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(_whereFrom))
                    {
                        _isCProductAlive = true;
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                    else
                    {
                        _isCProductAlive = false;
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
        }
        #endregion


        private void V_AddEditProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCProductAlive)
                Dispose();
            else
            {
                _cProduct.Dispose();
                Dispose();
            }
        }
    }
}
