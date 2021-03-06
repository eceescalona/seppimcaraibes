﻿namespace SeppimCaraibesApp.Domain.View.Order
{
    using System;
    using System.Windows.Forms;
    using System.Data.Entity;
    using DevExpress.XtraEditors;
    using System.Collections.Generic;
    using SeppimCaraibesApp.Domain.Controller;

    internal partial class V_ListOrdersForm : Form, IListOrders
    {
        private const string NAME_FORM = "Listar Ordenes";
        private const string MESSAGE_SHOW_ERROR = "El documento no pudo ser mostrado. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_MESSAGE = "Si elimina la orden del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar la orden ";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CONVERT_MESSAGE = "Uds. está cambiando la orden de Orden Firme a Facturar. ¿Está seguro(a) de querer continuar?";
        private const string CONVERT_MESSAGE_ERROR = "Ha ocurrido un error y no se pudo convertir la orden.Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly bool _isCallFrom;
        private readonly C_Order _cOrden;
        private bool _isCOrdenAlive;


        #region Ctor
        public V_ListOrdersForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = new C_Order();
            _isCOrdenAlive = true;
            _isCallFrom = false;
        }

        public V_ListOrdersForm(C_Order cOrden)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = cOrden;
            _isCOrdenAlive = true;
            _isCallFrom = true;

            closeBBI.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            closeBBI.Enabled = false;
            listOrdersRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            FormBorderStyle = FormBorderStyle.Sizable;
        }
        #endregion


        private void V_ListOrdersForm_Load(object sender, EventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrden.GetContext();
            dbContext.OrdersViews.Load();
            ordersBS.DataSource = dbContext.OrdersViews.Local.ToBindingList();
        }

        private void Refresh(Data.ORM.OrdersView row)
        {
            int rowHandle = 0;
            var list = new List<Data.ORM.OrdersView>();
            while (ordersGV.IsValidRowHandle(rowHandle))
            {
                var data = (Data.ORM.OrdersView)ordersGV.GetRow(rowHandle);
                if (data.Order_Code == row.Order_Code)
                {
                    list.Add(data);
                }
                rowHandle++;
            }

            foreach (var item in list)
            {
                _cOrden.GetContext().Entry(item).Reload();
            }
        }


        #region IListOrders
        public void RefreshView()
        {
            ordersBS.ResetBindings(true);
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrden.GetContext();
            dbContext.OrdersViews.Load();
            ordersBS.DataSource = dbContext.OrdersViews.Local.ToBindingList();
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cOrden.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cOrden.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cOrden.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ordersGV.IsFindPanelVisible)
            {
                ordersGV.HideFindPanel();
            }
            else
            {
                ordersGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ordersGV.ShowFilterEditor(ordersGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);

                    using (var editOrder = new V_AddEditOrderForm(_cOrden, row.Order_Code)
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    })
                    {
                        editOrder.BringToFront();
                        DialogResult result = editOrder.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            RefreshView();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            RefreshView();
                        }
                        else if (result == DialogResult.Abort)
                        {
                            MessageBox.Show(EDIT_ERROR_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Order_Code + "?", _cOrden.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.DeleteOrder(this, row.Order_Code);
                        Refresh(row);
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[2])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(CONVERT_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.EditOrder(this, row.Order_Code, EOrderProcessState.Invoice);
                        Refresh(row);
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(CONVERT_MESSAGE_ERROR, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[3])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);

                    DialogResult result = MessageBox.Show("Uds. quiere visualizar la columna [Precio Unitario]?",
                        _cOrden.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        using (var documentView = new V_ReportOrderForm(_cOrden, row.Order_Code, false)
                        {
                            StartPosition = FormStartPosition.CenterScreen
                        })
                        {
                            documentView.BringToFront();
                            documentView.ShowDialog();
                        }
                    }
                    else
                    {
                        using (var documentView = new V_ReportOrderForm(_cOrden, row.Order_Code)
                        {
                            StartPosition = FormStartPosition.CenterScreen
                        })
                        {
                            documentView.BringToFront();
                            documentView.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(MESSAGE_SHOW_ERROR, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CloseBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            C_Log _cLog = new C_Log();
            _cLog.Write(CLOSE_MESSAGE, ETypeOfMessage.Information);

            Close();
        }

        private void V_ListOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCOrdenAlive && !_isCallFrom)
            {
                _cOrden.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
