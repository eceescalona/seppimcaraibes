using System.Data.Entity;
namespace SeppimCaraibesApp.Domain.View.Order
{
    using DevExpress.XtraEditors;
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;

    internal partial class V_ListQuotesForm : Form, Controller.IListOrders
    {
        private const string NAME_FORM = "Listar Cotizaciones";
        private const string DELETE_MESSAGE = "Si elimina la orden del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar la orden ";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "La operación ha sido cancelada.";
        private const string CONVERT_MESSAGE = "Uds. está cambiando la orden de Cotizar a Orden Firme. ¿Está seguro(a) de querer continuar?";
        private const string CONVERT_MESSAGE_ERROR = "Ha ocurrido un error y no se pudo convertir la orden.Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";

        private bool _isCallFrom;
        private Controller.C_Order _cOrden;
        private bool _isCOrdenAlive;


        #region Ctor
        public V_ListQuotesForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = new Controller.C_Order();
            _isCOrdenAlive = true;
            _isCallFrom = false;
        }

        public V_ListQuotesForm(Controller.C_Order cOrden)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = cOrden;
            _isCOrdenAlive = true;
            _isCallFrom = true;
        }
        #endregion


        private void V_ListQuotesForm_Load(object sender, EventArgs e)
        {
            quotesEIFS.GetQueryable += QuotesEIFS_GetQueryable;

        }
        void QuotesEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cOrden.GetContext();
            e.QueryableSource = dataContext.QuotesViews;
        }

        private void Refresh(Data.ORM.QuotesView row)
        {
            int rowHandle = 0;
            var list = new List<Data.ORM.QuotesView>();
            while (quotesGV.IsValidRowHandle(rowHandle))
            {
                var data = (Data.ORM.QuotesView)quotesGV.GetRow(rowHandle);
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
            this.quotesEIFS.GetQueryable += QuotesEIFS_GetQueryable;

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

            if (quotesGV.IsFindPanelVisible)
            {
                quotesGV.HideFindPanel();
            }
            else
            {
                quotesGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quotesGV.ShowFilterEditor(quotesGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region OrderManage
        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                _isCOrdenAlive = true;
                var row = (Data.ORM.QuotesView)quotesGV.GetRow(quotesGV.FocusedRowHandle);
                var editOrder = new V_AddEditQuoteForm(_cOrden, row.Order_Code);
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
                    var row = (Data.ORM.QuotesView)quotesGV.GetRow(quotesGV.FocusedRowHandle);
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
                    var row = (Data.ORM.QuotesView)quotesGV.GetRow(quotesGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(CONVERT_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.EditOrder(this, row.Order_Code, EOrderProcessState.Order);
                        Refresh(row);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(CONVERT_MESSAGE_ERROR, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        private void ListOrdersBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var listOrders = new V_ListOrdersForm(_cOrden);
            listOrders.BringToFront();
            listOrders.ShowDialog();
        }

        private void V_ListQuotesForm_FormClosed(object sender, FormClosedEventArgs e)
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
