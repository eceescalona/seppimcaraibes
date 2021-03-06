﻿namespace SeppimCaraibesApp.Domain.View.Order
{
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Data.Entity;
    using SeppimCaraibesApp.Domain.Controller;

    internal partial class V_ListPreOrdersForm : Form, IListOrders
    {
        private const string NAME_FORM = "Listar Pre-Ordenes";
        private const string SELECT_PROVIDER = "Uds. va a seleccionar un proveedor y se previsualizará el documento de la Cotización en blanco. " +
            "¿Está seguro(a) de querer continuar?";
        private const string DELETE_MESSAGE = "Si elimina la orden del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar la orden ";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar la nueva orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CONVERT_MESSAGE = "Uds. está cambiando la Pre-Orden a Cotizar. ¿Está seguro(a) de querer continuar?";
        private const string MESSAGE_SHOW_ERROR = "El documento no pudo ser mostrado. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CONVERT_MESSAGE_ERROR = "Ha ocurrido un error y no se pudo convertir la orden.Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Order _cOrder;
        private bool _isCOrdenAlive;


        #region Ctor
        public V_ListPreOrdersForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrder = new C_Order();
            _isCOrdenAlive = true;
        }

        public V_ListPreOrdersForm(C_Order cOrden)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrder = cOrden;
            _isCOrdenAlive = true;
        }
        #endregion


        private void V_ListPreOrdersForm_Load(object sender, EventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrder.GetContext();
            dbContext.PreOrdersViews.Load();
            preOrdersBS.DataSource = dbContext.PreOrdersViews.Local.ToBindingList();
        }

        private void Refresh(Data.ORM.PreOrdersView row)
        {
            int rowHandle = 0;
            var list = new List<Data.ORM.PreOrdersView>();
            while (preOrdersGV.IsValidRowHandle(rowHandle))
            {
                var data = (Data.ORM.PreOrdersView)preOrdersGV.GetRow(rowHandle);
                if (data.Order_Code == row.Order_Code)
                {
                    list.Add(data);
                }
                rowHandle++;
            }

            foreach (var item in list)
            {
                _cOrder.GetContext().Entry(item).Reload();
            }
        }


        #region IListOrders
        public void RefreshView()
        {
            preOrdersBS.ResetBindings(true);
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrder.GetContext();
            dbContext.PreOrdersViews.Load();
            preOrdersBS.DataSource = dbContext.PreOrdersViews.Local.ToBindingList();
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


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (preOrdersGV.IsFindPanelVisible)
            {
                preOrdersGV.HideFindPanel();
            }
            else
            {
                preOrdersGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preOrdersGV.ShowFilterEditor(preOrdersGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region OrderManage
        private void RegisterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                _isCOrdenAlive = true;

                using (var addOrder = new V_AddEditPreOrderForm(_cOrder)
                {
                    StartPosition = FormStartPosition.CenterScreen
                })
                {
                    addOrder.BringToFront();
                    DialogResult result = addOrder.ShowDialog();
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

        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.PreOrdersView)preOrdersGV.GetRow(preOrdersGV.FocusedRowHandle);

                    using (var editOrder = new V_AddEditPreOrderForm(_cOrder, row.Order_Code)
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
                            MessageBox.Show(EDIT_ERROR_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var row = (Data.ORM.PreOrdersView)preOrdersGV.GetRow(preOrdersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Order_Code + "?", _cOrder.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrder.DeleteOrder(this, row.Order_Code);

                        Refresh(row);
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[2])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.PreOrdersView)preOrdersGV.GetRow(preOrdersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(CONVERT_MESSAGE, _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrder.EditOrder(this, row.Order_Code, EOrderProcessState.Quote);

                        Refresh(row);
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(CONVERT_MESSAGE_ERROR, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[3])
            {
                try
                {
                    _isCOrdenAlive = true;
                    var row = (Data.ORM.PreOrdersView)preOrdersGV.GetRow(preOrdersGV.FocusedRowHandle);

                    if (_cOrder.ValidateProvider(row.Order_Code))
                    {
                        var documentView = new V_ReportQuoteForm(_cOrder, row.Order_Code)
                        {
                            StartPosition = FormStartPosition.CenterScreen
                        };
                        documentView.BringToFront();
                        documentView.ShowDialog();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(SELECT_PROVIDER, _cOrder.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            using (var selectProvider = new D_SelectProviderForm(_cOrder, row.Order_Code)
                            {
                                StartPosition = FormStartPosition.CenterScreen
                            })
                            {
                                selectProvider.BringToFront();
                                DialogResult resultDialog = selectProvider.ShowDialog();
                                if (resultDialog == DialogResult.OK)
                                {
                                    var documentView = new V_ReportQuoteForm(_cOrder, row.Order_Code)
                                    {
                                        StartPosition = FormStartPosition.CenterScreen
                                    };
                                    documentView.BringToFront();
                                    documentView.ShowDialog();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(MESSAGE_SHOW_ERROR, _cOrder.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        private void ListQuotesBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var listQuotes = new V_ListQuotesForm(_cOrder)
                {
                    StartPosition = FormStartPosition.CenterScreen
                })
                {
                    listQuotes.BringToFront();
                    listQuotes.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(ex.Message, ETypeOfMessage.Error);
            }
        }


        private void CloseBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            C_Log _cLog = new C_Log();
            _cLog.Write(CLOSE_MESSAGE, ETypeOfMessage.Information);

            Close();
        }

        private void V_ListPreOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCOrdenAlive)
            {
                _cOrder.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
