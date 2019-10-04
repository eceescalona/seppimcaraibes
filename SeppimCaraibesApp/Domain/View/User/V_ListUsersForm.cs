namespace SeppimCaraibesApp.Domain.View.User
{
    using DevExpress.XtraEditors;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class V_ListUsersForm : Form, Controller.IListUsers
    {
        private const string NAME_FORM = "Listar Usuarios";
        private const string DISSABLE_MESSAGE = "Inhabilitar un usuario causa que el mismo no pueda acceder al sistema. ¿Está seguro(a) de querer inhabilitar al usuario: ";
        private const string ENABLE_MESSAGE = "Habilitar un usuario causa que el mismo pueda acceder al sistema. ¿Está seguro(a) de querer habilitar al usuario: ";
        private const string DELETE_MESSAGE = "Si elimina un usuario del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar al usuario?";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo usuario. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar el usuario. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar el usuario. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";

        private readonly Controller.C_User _cUser;
        private bool _isCUserAlive;


        #region Ctor
        public V_ListUsersForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cUser = new Controller.C_User();
            _isCUserAlive = false;
        }

        public V_ListUsersForm(Controller.C_User cUser)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cUser = cUser;
            _isCUserAlive = true;
        }
        #endregion


        private void V_ListUsersForm_Load(object sender, System.EventArgs e)
        {
            userEIFS.GetQueryable += UserEIFS_GetQueryable;
        }

        private void UserEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cUser.GetContext();
            e.QueryableSource = dataContext.UserViews;
        }

        private void UsersGV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (usersGV.GetRow(e.RowHandle) is Data.ORM.UserView row)
            {
                if (row.Enable == false)
                {
                    e.Appearance.BackColor = Color.LightCoral;
                    e.Appearance.BackColor2 = Color.White;
                    e.HighPriority = true;
                }
            }
        }


        #region IListUsers
        public void RefreshView()
        {
            userEIFS.Refresh();
            userEIFS.GetQueryable += UserEIFS_GetQueryable;
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cUser.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cUser.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cUser.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (usersGV.IsFindPanelVisible)
            {
                usersGV.HideFindPanel();
            }
            else
            {
                usersGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            usersGV.ShowFilterEditor(usersGV.Columns[1]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region UserManagement
        private void RegisterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isCUserAlive = true;
            var addUser = new V_AddEditUserForm(_cUser)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            addUser.BringToFront();
            DialogResult result = addUser.ShowDialog();
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
                MessageBox.Show(ADD_ERROR_MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionsRIBE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;

            if (e.Button == btnEdit.Properties.Buttons[0])
            {
                _isCUserAlive = true;
                var row = usersGV.GetRow(usersGV.FocusedRowHandle) as Data.ORM.UserView;
                _cUser.ShowDisableCause(this, row.UserId);
            }

            if (e.Button == btnEdit.Properties.Buttons[1])
            {
                _isCUserAlive = true;
                var row = usersGV.GetRow(usersGV.FocusedRowHandle) as Data.ORM.UserView;
                var editCustomer = new V_AddEditUserForm(_cUser, row.UserId, false)
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                editCustomer.BringToFront();
                DialogResult result = editCustomer.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _cUser.GetContext().Entry(row).Reload();
                    RefreshView();
                }
                else if (result == DialogResult.Cancel)
                {
                    RefreshView();
                }
                else if (result == DialogResult.Abort)
                {
                    MessageBox.Show(EDIT_ERROR_MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[2])
            {
                try
                {
                    _isCUserAlive = true;
                    var row = (Data.ORM.UserView)usersGV.GetRow(usersGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.User + "?", _cUser.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cUser.DeleteUser(this, row.UserId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnableRICE_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                _isCUserAlive = true;
                var row = usersGV.GetRow(usersGV.FocusedRowHandle) as Data.ORM.UserView;
                string message = string.Empty;

                CheckEdit enable = sender as CheckEdit;
                if (!enable.Checked)
                {
                    DialogResult result = MessageBox.Show(DISSABLE_MESSAGE + row.User + "?", _cUser.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var disableCause = new D_DisableCauseForm(_cUser);
                        if (disableCause.DialogResult == DialogResult.OK)
                        {
                            message = disableCause.cause;
                        }
                        disableCause.Dispose();

                        _cUser.DisableUser(this, row.UserId, message);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(ENABLE_MESSAGE + row.User + "?", _cUser.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cUser.EnableUser(this, row.UserId);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(EDIT_ERROR_MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


        private void CloseBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void V_ListUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCUserAlive)
                Dispose();
            else
            {
                _cUser.Dispose();
                Dispose();
            }
        }
    }
}
