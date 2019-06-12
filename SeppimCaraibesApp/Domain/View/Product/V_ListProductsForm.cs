using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SeppimCaraibesApp.Domain.View.Product
{
    internal partial class V_ListProductsForm : Form, Controller.IListProducts
    {
        private const string NAME_FORM = "Listar Productos";
        private const string DELETE_MESSAGE = "Si elimina el producto del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar el producto ";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo producto. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar el producto. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar el producto. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "La operación ha sido cancelada.";

        private Controller.C_Product _cProduct;
        private bool _isCProductAlive;


        #region Ctor
        public V_ListProductsForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cProduct = new Controller.C_Product();
            _isCProductAlive = true;
        }

        public V_ListProductsForm(Controller.C_Product cProduct)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cProduct = cProduct;
            _isCProductAlive = true;
        }
        #endregion


        private void V_ListProductsForm_Load(object sender, EventArgs e)
        {
            productsEIFS.GetQueryable += ProductEIFS_GetQueryable;
        }

        private void ProductEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cProduct.GetContext();
            e.QueryableSource = dataContext.ProductsViews;
        }

        private void ProductsGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (productsGV.GetRow(e.RowHandle) is Data.ORM.ProductsView row)
            {
                if (string.IsNullOrWhiteSpace(row.Provider_Code) && string.IsNullOrWhiteSpace(row.Provider_Name))
                {
                    e.Appearance.BackColor = Color.LightCoral;
                    e.Appearance.BackColor2 = Color.White;
                    e.HighPriority = true;
                }
            }
        }


        #region IListProviders
        public void RefreshView()
        {
            productsEIFS.Refresh();
            productsEIFS.GetQueryable += ProductEIFS_GetQueryable;
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


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productsGV.IsFindPanelVisible)
            {
                productsGV.HideFindPanel();
            }
            else
            {
                productsGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productsGV.ShowFilterEditor(productsGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region ProductManage
        private void RegisterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isCProductAlive = true;
            var addProduct = new V_AddEditProductForm(_cProduct);
            addProduct.StartPosition = FormStartPosition.CenterScreen;
            addProduct.BringToFront();
            DialogResult result = addProduct.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshView();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show(CANCEL_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshView();
            }
            else
            {
                MessageBox.Show(ADD_ERROR_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                _isCProductAlive = true;
                var row = productsGV.GetRow(productsGV.FocusedRowHandle) as Data.ORM.ProductsView;
                var editProduct = new V_AddEditProductForm(_cProduct, row.Product_Code);
                editProduct.StartPosition = FormStartPosition.CenterScreen;
                editProduct.BringToFront();
                DialogResult result = editProduct.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshView();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show(CANCEL_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Abort)
                {
                    MessageBox.Show(EDIT_ERROR_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[1])
            {
                try
                {
                    _isCProductAlive = true;
                    var row = (Data.ORM.ProductsView)productsGV.GetRow(productsGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Product_Name + "?", _cProduct.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cProduct.DeleteProduct(this, row.Product_Code);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cProduct.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        private void V_ListProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCProductAlive)
            {
                _cProduct.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
