﻿namespace SeppimCaraibesApp.Domain.View.Customer
{
    using DevExpress.XtraEditors;
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class V_ListCustomersForm : Form, IListCustomers
    {
        private const string NAME_FORM = "Listar Clientes";
        private const string DELETE_MESSAGE = "Si elimina al cliente del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar al cliente ";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo cliente. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar al cliente. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar al cliente. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Customer _cCustomer;
        private bool _isCCustomerAlive;


        #region Ctor
        public V_ListCustomersForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cCustomer = new C_Customer();
            _isCCustomerAlive = true;
        }

        public V_ListCustomersForm(C_Customer cCustomer)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cCustomer = cCustomer;
            _isCCustomerAlive = true;
        }
        #endregion


        private void V_ListCustomersForm_Load(object sender, EventArgs e)
        {
            customersEIFS.GetQueryable += CustomerEIFS_GetQueryable;
        }

        void CustomerEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cCustomer.GetContext();
            e.QueryableSource = dataContext.CustomersViews;
        }

        private void CustomersGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (customersGV.GetRow(e.RowHandle) is Data.ORM.CustomersView row)
            {
                if (string.IsNullOrWhiteSpace(row.Phone) && string.IsNullOrWhiteSpace(row.Email))
                {
                    e.Appearance.BackColor = Color.LightCoral;
                    e.Appearance.BackColor2 = Color.White;
                    e.HighPriority = true;
                }
            }
        }


        #region IListCustomers
        public void RefreshView()
        {
            customersEIFS.Refresh();
            customersEIFS.GetQueryable += CustomerEIFS_GetQueryable;
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cCustomer.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cCustomer.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cCustomer.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customersGV.IsFindPanelVisible)
            {
                customersGV.HideFindPanel();
            }
            else
            {
                customersGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customersGV.ShowFilterEditor(customersGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region CustomerManage
        private void RegisterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                _isCCustomerAlive = true;

                using (var addCustomer = new V_AddEditCustomerForm(_cCustomer)
                {
                    StartPosition = FormStartPosition.CenterScreen
                })
                {
                    addCustomer.BringToFront();
                    DialogResult result = addCustomer.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshView();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        RefreshView();
                    }
                    else
                    {
                        MessageBox.Show(ADD_ERROR_MESSAGE, _cCustomer.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }

        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                try
                {
                    _isCCustomerAlive = true;
                    var row = customersGV.GetRow(customersGV.FocusedRowHandle) as Data.ORM.CustomersView;

                    using (var editCustomer = new V_AddEditCustomerForm(_cCustomer, row.Code)
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    })
                    {
                        editCustomer.BringToFront();
                        DialogResult result = editCustomer.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _cCustomer.GetContext().Entry(row).Reload();
                            RefreshView();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            RefreshView();
                        }
                        else if (result == DialogResult.Abort)
                        {
                            MessageBox.Show(EDIT_ERROR_MESSAGE, _cCustomer.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[1])
            {
                try
                {
                    _isCCustomerAlive = true;
                    var row = (Data.ORM.CustomersView)customersGV.GetRow(customersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Name + "?", _cCustomer.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cCustomer.DeleteCustomer(this, row.Code);
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cCustomer.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        private void CloseBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            C_Log _cLog = new C_Log();
            _cLog.Write(CLOSE_MESSAGE, ETypeOfMessage.Information);

            Close();
        }

        private void V_ListCustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCCustomerAlive)
            {
                _cCustomer.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
