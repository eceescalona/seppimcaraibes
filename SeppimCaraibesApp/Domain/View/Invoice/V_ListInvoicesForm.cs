﻿namespace SeppimCaraibesApp.Domain.View.Invoice
{
    using System.Data.Entity;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    internal partial class V_ListInvoicesForm : Form, Controller.IListOrders
    {
        private const string NAME_FORM = "Listar Facturas";
        private const string MESSAGE_SHOW_ERROR = "El documento no pudo ser mostrado. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_MESSAGE = "Si elimina la factura del sistema, este desaparecerá permanentemente del mismo; así como la orden asociada. " +
            "¿Está seguro(a) de querer eliminar la orden ";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar la factura. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar la factura. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "La operación ha sido cancelada.";
        private const string CONVERT_MESSAGE = "Uds. está cambiando la factura a Cerrada. ¿Está seguro(a) de querer continuar?";
        private const string CONVERT_MESSAGE_ERROR = "Ha ocurrido un error y no se pudo cerrar la factura.Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";

        private readonly Controller.C_Order _cOrden;
        private bool _isCOrdenAlive;


        public V_ListInvoicesForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = new Controller.C_Order();
            _isCOrdenAlive = true;
        }


        private void V_ListInvoicesForm_Load(object sender, EventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrden.GetContext();
            dbContext.InvoicesViews.Load();
            invoicesBS.DataSource = dbContext.InvoicesViews.Local.ToBindingList();
        }

        private void Refresh(Data.ORM.InvoicesView row)
        {
            int rowHandle = 0;
            var list = new List<Data.ORM.InvoicesView>();
            while (invoiceGV.IsValidRowHandle(rowHandle))
            {
                var data = (Data.ORM.InvoicesView)invoiceGV.GetRow(rowHandle);
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
            invoicesBS.ResetBindings(true);
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrden.GetContext();
            dbContext.InvoicesViews.Load();
            invoicesBS.DataSource = dbContext.InvoicesViews.Local.ToBindingList();
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

            if (invoiceGV.IsFindPanelVisible)
            {
                invoiceGV.HideFindPanel();
            }
            else
            {
                invoiceGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            invoiceGV.ShowFilterEditor(invoiceGV.Columns[1]);
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
                _isCOrdenAlive = true;
                var row = (Data.ORM.InvoicesView)invoiceGV.GetRow(invoiceGV.FocusedRowHandle);
                var editOrder = new V_AddEditInvoiceForm(_cOrden, row.Order_Code);
                editOrder.StartPosition = FormStartPosition.CenterScreen;
                editOrder.BringToFront();
                DialogResult result = editOrder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshView();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show(CANCEL_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Information), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Abort)
                {
                    MessageBox.Show(EDIT_ERROR_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[1])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.InvoicesView)invoiceGV.GetRow(invoiceGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Order_Code + "?", _cOrden.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.DeleteOrder(this, row.Order_Code);
                        Refresh(row);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[2])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.InvoicesView)invoiceGV.GetRow(invoiceGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(CONVERT_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.EditOrder(this, row.Order_Code, EInvoiceState.Settled);
                        Refresh(row);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(CONVERT_MESSAGE_ERROR, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[3])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.InvoicesView)invoiceGV.GetRow(invoiceGV.FocusedRowHandle);
                    var documentView = new V_ReportInvoiceForm(_cOrden, row.Order_Code);
                    documentView.StartPosition = FormStartPosition.CenterScreen;
                    documentView.BringToFront();
                    documentView.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show(MESSAGE_SHOW_ERROR, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void V_ListInvoicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCOrdenAlive)
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
