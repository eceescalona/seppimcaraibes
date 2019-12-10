namespace SeppimCaraibesApp.Domain.View.Role
{
    using DevExpress.XtraEditors;
    using SeppimCaraibesApp.Domain.Controller;
    using System;
    using System.Windows.Forms;

    internal partial class V_ListRolesForm : Form, IListRoles
    {
        private const string NAME_FORM = "Listar Roles";
        private const string ADD_USER_ERROR = "Ha ocurrido un error y no se pudo registrar el nuevo usuario. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string DELETE_MESSAGE = "Si elimina un rol del sistema, este desaparecerá permanentemente del mismo. " +
            "¿Está seguro(a) de querer eliminar el rol?";
        private const string ADD_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo registrar el nuevo rol. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string EDIT_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo editar el rol. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string DELETE_ERROR_MESSAGE = "Ha ocurrido un error y no se pudo eliminar el rol. Porfavor vuelva a intentarlo. Si el error persiste llame al desarrollador." +
            " Gracias y disculpe las molestias.";
        private const string CLOSE_MESSAGE = "Uds. a terminado, la ventana cerrará.";

        private readonly C_Role _cRole;
        private readonly C_User _cUser;
        private bool _isCRoleAlive;


        #region Ctor
        public V_ListRolesForm()
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cRole = new C_Role();
            _isCRoleAlive = true;
        }

        public V_ListRolesForm(C_User cUser)
        {
            InitializeComponent();
            Text = NAME_FORM;

            _cRole = new C_Role();
            _isCRoleAlive = true;

            _cUser = cUser;
        }
        #endregion


        private void V_ListRolesForm_Load(object sender, EventArgs e)
        {
            roleEIFS.GetQueryable += RoleEIFS_GetQueryable;
        }

        void RoleEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cRole.GetContext();
            e.QueryableSource = dataContext.RoleViews;
        }


        #region IListRoles
        public void RefreshView()
        {
            roleEIFS.Refresh();
            roleEIFS.GetQueryable += RoleEIFS_GetQueryable;
        }

        public void ShowMessage(ETypeOfMessage typeOfMessage, string message)
        {
            switch (typeOfMessage)
            {
                case ETypeOfMessage.Warning:
                    MessageBox.Show(message, _cRole.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ETypeOfMessage.Error:
                    MessageBox.Show(message, _cRole.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, _cRole.GetEnumDescription(typeOfMessage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion


        #region RibbonControl
        private void FindBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (roleGV.IsFindPanelVisible)
            {
                roleGV.HideFindPanel();
            }
            else
            {
                roleGV.ShowFindPanel();
            }
        }

        private void FilterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            roleGV.ShowFilterEditor(roleGV.Columns[0]);
        }

        private void RefreshBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshView();
        }
        #endregion


        #region UserManagement
        private void RegisterBBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                _isCRoleAlive = true;

                using (var addUser = new V_AddEditRoleForm(_cRole)
                {
                    StartPosition = FormStartPosition.CenterScreen
                })
                {
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
                        MessageBox.Show(ADD_ERROR_MESSAGE, _cRole.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    _isCRoleAlive = true;
                    var row = roleGV.GetRow(roleGV.FocusedRowHandle) as Data.ORM.RoleView;

                    using (var addUser = new User.V_AddEditUserForm(_cUser, row.RoleId)
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    })
                    {
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
                            MessageBox.Show(ADD_USER_ERROR, _cRole.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    _isCRoleAlive = true;
                    var row = roleGV.GetRow(roleGV.FocusedRowHandle) as Data.ORM.RoleView;

                    using (var editCustomer = new V_AddEditRoleForm(_cRole, row.RoleId)
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    })
                    {
                        editCustomer.BringToFront();
                        DialogResult result = editCustomer.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _cRole.GetContext().Entry(row).Reload();
                            RefreshView();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            RefreshView();
                        }
                        else if (result == DialogResult.Abort)
                        {
                            MessageBox.Show(EDIT_ERROR_MESSAGE, _cRole.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);
                }
            }

            if (e.Button == btnEdit.Properties.Buttons[2])
            {
                try
                {
                    _isCRoleAlive = true;
                    var row = (Data.ORM.RoleView)roleGV.GetRow(roleGV.FocusedRowHandle);
                    DialogResult result = MessageBox.Show(DELETE_MESSAGE + row.Name + "?", _cRole.GetEnumDescription(ETypeOfMessage.Warning),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _cRole.DeleteRole(this, row.RoleId);
                    }
                }
                catch (Exception ex)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(ex.Message, ETypeOfMessage.Error);

                    MessageBox.Show(DELETE_ERROR_MESSAGE, _cRole.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void V_ListRolesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCRoleAlive)
            {
                _cRole.Dispose();
                Dispose();
            }
            else
            {
                Dispose();
            }
        }
    }
}
