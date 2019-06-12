namespace SeppimCaraibesApp.Domain.View.Provider
{
    using DevExpress.XtraEditors;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class V_ListProvidersForm : Form, Controller.IListProviders
    {
        private const string NAME_FORM = "Listar Proveedores";
        private const string DELETE_MESSAGE = "Si elimina al proveedor del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar al proveedor ";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo proveedor. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar al proveedor. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar al proveedor. Porfavor vuelva a intentarlo. " +
            "Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "La operación ha sido cancelada.";

        private Controller.C_Provider _cProvider;
        private bool _isCProviderAlive;


        #region Ctor
        public V_ListProvidersForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cProvider = new Controller.C_Provider();
            _isCProviderAlive = true;
        }

        public V_ListProvidersForm(Controller.C_Provider cProvider)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cProvider = cProvider;
            _isCProviderAlive = true;
        }
        #endregion


        private void V_ListProvidersForm_Load(object sender, EventArgs e)
        {
            providersEIFS.GetQueryable += ProviderEIFS_GetQueryable;
        }

        private void ProviderEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cProvider.GetContext();
            e.QueryableSource = dataContext.ProvidersViews;
        }

        private void ProvidersGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (providersGV.GetRow(e.RowHandle) is Data.ORM.ProvidersView row)
            {
                if (string.IsNullOrWhiteSpace(row.Phone) && string.IsNullOrWhiteSpace(row.Email))
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
            providersEIFS.Refresh();
            providersEIFS.GetQueryable += ProviderEIFS_GetQueryable;
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


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (providersGV.IsFindPanelVisible)
            {
                providersGV.HideFindPanel();
            }
            else
            {
                providersGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            providersGV.ShowFilterEditor(providersGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region ProviderManage
        private void RegisterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isCProviderAlive = true;
            var addProvider = new V_AddEditProviderForm(_cProvider);
            addProvider.StartPosition = FormStartPosition.CenterScreen;
            addProvider.BringToFront();
            DialogResult result = addProvider.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshView();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show(CANCEL_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshView();
            }
            else
            {
                MessageBox.Show(ADD_ERROR_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                _isCProviderAlive = true;
                var row = providersGV.GetRow(providersGV.FocusedRowHandle) as Data.ORM.ProvidersView;
                var editProvider = new V_AddEditProviderForm(_cProvider, row.Provider_Code);
                editProvider.StartPosition = FormStartPosition.CenterScreen;
                editProvider.BringToFront();
                DialogResult result = editProvider.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _cProvider.GetContext().Entry(row).Reload();
                    RefreshView();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show(CANCEL_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Abort)
                {
                    MessageBox.Show(EDIT_ERROR_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[1])
            {
                try
                {
                    _isCProviderAlive = true;
                    var row = (Data.ORM.ProvidersView)providersGV.GetRow(providersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Provider_Name + "?", _cProvider.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cProvider.DeleteProvider(this, row.Provider_Code);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cProvider.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        private void V_ListProvidersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCProviderAlive)
            {
                _cProvider.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
