namespace SeppimCaraibesApp.Domain.View.Order
{
    using System;
    using System.Windows.Forms;
    using System.Data.Entity;
    using DevExpress.XtraEditors;

    internal partial class V_ListOrdersForm : Form, Controller.IListOrders
    {
        private const string NAME_FORM = "Listar Ordenes";
        private const string DELETE_MESSAGE = "Si elimina la orden del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar la orden ";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar la orden. Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "La operación ha sido cancelada.";
        private const string CONVERT_MESSAGE = "Uds. está cambiando la orden de Orden Firme a Facturar. ¿Está seguro(a) de querer continuar?";
        private const string CONVERT_MESSAGE_ERROR = "Ha ocurrido un error y no se pudo convertir la orden.Porfavor vuelva a intentarlo." +
            " Si el error persiste llame al desarrollador. Gracias y disculpe las molestias.";

        private readonly bool _isCallFrom;
        private readonly Controller.C_Order _cOrden;
        private bool _isCOrdenAlive;


        #region Ctor
        public V_ListOrdersForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = new Controller.C_Order();
            _isCOrdenAlive = true;
            _isCallFrom = false;

            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrden.GetContext();
            dbContext.OrdersViews.Load();
            ordersBS.DataSource = dbContext.OrdersViews.Local.ToBindingList();
        }

        public V_ListOrdersForm(Controller.C_Order cOrden)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cOrden = cOrden;
            _isCOrdenAlive = true;
            _isCallFrom = true;
        }
        #endregion


        private void V_ListOrdersForm_Load(object sender, EventArgs e)
        {

        }


        #region IListOrders
        public void RefreshView()
        {
            ordersBS.Clear();
            Data.ORM.SeppimCaraibesLocalEntities dbContext = _cOrden.GetContext();
            dbContext.OrdersViews.LoadAsync().ContinueWith(loadTask =>
            {
                ordersBS.DataSource = dbContext.OrdersViews.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
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


        #region OrderManage
        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                _isCOrdenAlive = true;
                var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);
                var editOrder = new V_AddEditOrderForm(_cOrden, row.Order_Code);
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
                    var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Order_Code + "?", _cOrden.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.DeleteOrder(this, row.Order_Code);
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
                    var row = (Data.ORM.OrdersView)ordersGV.GetRow(ordersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(CONVERT_MESSAGE, _cOrden.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cOrden.EditOrder(this, row.Order_Code, EOrderProcessState.Invoice);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(CONVERT_MESSAGE_ERROR, _cOrden.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


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
