namespace SeppimCaraibesApp.Domain.View.Provider
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

    internal partial class V_AddEditProviderForm : Form, Controller.IAddEditProvider
    {
        private const string CANCEL_ADD_PRODUCT_MESSAGE = "La operación ha sido cancelada.";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo producto. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string LABEL_MESSAGE = "Debe elegir al menos un producto";
        private const string CALL_FROM_PRODUCT = "Product";
        private const string NAME_FORM_ADD = "Registrar Proveedor";
        private const string NAME_FORM_EDIT = "Editar Proveedor";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private Controller.C_Provider _cProvider;
        private bool _isCProviderAlive;
        private string _whereFrom;
        private bool _isAddOrEdit;
        private bool _isFieldWithError;
        private string _idProduct;
        public string code;


        #region Ctor
        public V_AddEditProviderForm()
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cProvider = new Controller.C_Provider();
            _isCProviderAlive = true;
            _whereFrom = CALL_FROM_PRODUCT;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idProduct = string.Empty;

            productsEIFS.GetQueryable += ProductsEIFS_GetQueryable;
            providerBS.DataSource = new Data.ORM.Provider();
        }

        public V_AddEditProviderForm(Controller.C_Provider cProvider)
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cProvider = cProvider;
            _isCProviderAlive = true;
            _whereFrom = string.Empty;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idProduct = string.Empty;

            productsEIFS.GetQueryable += ProductsEIFS_GetQueryable;
            providerBS.DataSource = new Data.ORM.Provider();
        }

        public V_AddEditProviderForm(Controller.C_Provider cProvider, string code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cProvider = cProvider;
            _isCProviderAlive = true;
            this.code = code;
            _whereFrom = string.Empty;
            _isAddOrEdit = true;
            _isFieldWithError = false;
            _idProduct = string.Empty;

            _cProvider.EditProvider(this, code);

            productsEIFS.GetQueryable += ProductsEIFS_GetQueryable;
        }
        #endregion


        private void V_AddEditProviderForm_Load(object sender, EventArgs e)
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

        void ProductsEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cProvider.GetContext();
            e.QueryableSource = dataContext.Products;
        }

        private void ProductsGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (_isAddOrEdit)
            {
                var provider = (Data.ORM.Provider)providerBS.Current;
                foreach (var product in provider.Products)
                {
                    if (productsGV.GetRow(e.RowHandle) is Data.ORM.Product row)
                    {
                        if (row.ProductId == product.ProductId)
                        {
                            productsGV.SelectRow(e.RowHandle);
                        }
                    }
                }

                e.HighPriority = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_idProduct))
                {
                    if (productsGV.GetRow(e.RowHandle) is Data.ORM.Product row)
                    {
                        if (row.ProductId == _idProduct)
                        {
                            productsGV.SelectRow(e.RowHandle);
                        }
                    }
                }
            }
        }


        #region IAddEditProvider
        public void EditProvider(Data.ORM.Provider provider)
        {
            providerBS.DataSource = provider;
        }

        public void RefreshView()
        {
            codeTE.Text = string.Empty;
            nameTE.Text = string.Empty;
            phoneTE.Text = string.Empty;
            emailTE.Text = string.Empty;
            addressME.Text = string.Empty;

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

            productsErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            productsErrorLC.Text = LABEL_MESSAGE;
            productsErrorLC.LineColor = Color.Black;
            productsErrorLC.ForeColor = Color.Black;

            productsEIFS.Refresh();
            productsEIFS.GetQueryable += ProductsEIFS_GetQueryable;
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
                    else if (emailTE.Name == field.Key)
                    {
                        emailErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        emailErrorLC.Text = field.Value;
                        emailErrorLC.LineColor = Color.Red;
                        emailErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        productsErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        productsErrorLC.Text = field.Value;
                        productsErrorLC.LineColor = Color.Red;
                        productsErrorLC.ForeColor = Color.Red;

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
                else if (emailTE.Name == fields.First().Key)
                {
                    emailTE.Focus();
                }
                else
                {
                    productsGridC.Focus();
                }
            }
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cProvider.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cProvider.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cProvider.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region ActionsButtons
        private void AddProductSP_Click(object sender, EventArgs e)
        {
            _isCProviderAlive = true;
            var addProduct = new Product.V_AddEditProductForm();
            addProduct.BringToFront();
            DialogResult result = addProduct.ShowDialog();
            if (result == DialogResult.OK)
            {
                _idProduct = addProduct.code;
                productsEIFS.Refresh();
                productsEIFS.GetQueryable += ProductsEIFS_GetQueryable;
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show(CANCEL_ADD_PRODUCT_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshView();
            }
            else
            {
                MessageBox.Show(ADD_ERROR_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var products = new List<Data.ORM.Product>();

                int[] indexs = productsGV.GetSelectedRows();

                for (int i = 0; i < indexs.Length; i++)
                {
                    if (indexs[i] != -1)
                    {
                        products.Add((Data.ORM.Product)productsGV.GetRow(indexs[i]));
                    }
                }

                var provider = (Data.ORM.Provider)providerBS.Current;
                provider.Products = products;

                if (_isAddOrEdit)
                {
                    _cProvider.EditProvider(this, provider);
                    _isCProviderAlive = true;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    _cProvider.AddProvider(this, provider);

                    if (!string.IsNullOrWhiteSpace(_whereFrom))
                    {
                        _isCProviderAlive = false;
                        code = provider.ProviderId;
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
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cProvider.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    acceptSB.Click += AcceptSB_Click;
                }
                else if (result == DialogResult.Abort)
                {
                    if (_isAddOrEdit)
                    {
                        _isCProviderAlive = true;
                        DialogResult = DialogResult.Abort;
                        Close();
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(_whereFrom))
                        {
                            code = string.Empty;
                            _isCProviderAlive = false;
                            DialogResult = DialogResult.Abort;
                            Close();
                        }
                        else
                        {
                            _isCProviderAlive = true;
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
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_isAddOrEdit)
            {
                if (result == DialogResult.Yes)
                {
                    _isCProviderAlive = true;
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
                        _isCProviderAlive = true;
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                    else
                    {
                        _isCProviderAlive = false;
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
        }
        #endregion


        private void V_AddEditProviderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCProviderAlive)
                Dispose();
            else
            {
                _cProvider.Dispose();
                Dispose();
            }
        }
    }
}
