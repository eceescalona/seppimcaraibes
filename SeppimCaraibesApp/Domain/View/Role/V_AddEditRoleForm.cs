namespace SeppimCaraibesApp.Domain.View.Role
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditRoleForm : Form, Controller.IAddEditRole
    {
        private const string NAME_FORM_ADD = "Registrar Rol";
        private const string LABEL_MESSAGE_PERMISSION = "Debe seleccionar al menos un permiso";
        private const string NAME_FORM_EDIT = "Editar Rol";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private readonly Controller.C_Role _cRole;
        private readonly bool _isAddOrEdit;
        private bool _isCRoleAlive;
        private bool _isFieldWithError;


        #region Ctor
        public V_AddEditRoleForm(Controller.C_Role cRole)
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cRole = cRole;
            _isCRoleAlive = true;
            _isAddOrEdit = false;
            _isFieldWithError = false;

            roleBS.DataSource = new Data.ORM.Role();
        }

        public V_AddEditRoleForm(Controller.C_Role cRole, int code)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cRole = cRole;
            _isCRoleAlive = true;
            _isAddOrEdit = true;
            _isFieldWithError = false;

            _cRole.EditRole(this, code);
        }
        #endregion


        private void V_AddEditRoleForm_Load(object sender, EventArgs e)
        {
            permissionEIFS.GetQueryable += PermissionEIFS_GetQueryable;
        }

        private void PermissionEIFS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cRole.GetContext();
            e.QueryableSource = dataContext.Permissions;
        }

        private void PermissionSLUEV_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (_isAddOrEdit)
            {
                var role = (Data.ORM.Role)roleBS.Current;
                if (role != null && (role.Permissions != null && role.Permissions.Count > 0))
                {
                    foreach (var permission in role.Permissions)
                    {
                        if (permissionSLUEV.GetRow(e.RowHandle) is Data.ORM.Permission row)
                        {
                            if (row.PermissionId == permission.PermissionId)
                            {
                                permissionSLUEV.SelectRow(e.RowHandle);
                            }
                        }
                    }

                    e.HighPriority = true;
                }
            }
        }


        #region IAddEditRole
        public void EditRole(Data.ORM.Role role)
        {
            roleBS.DataSource = role;
        }

        public void RefreshView()
        {
            nameTE.Text = string.Empty;
            descriptionME.Text = string.Empty;

            nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            nameErrorLC.Text = string.Empty;
            nameErrorLC.LineColor = Color.Black;
            nameErrorLC.ForeColor = Color.Black;

            descriptionErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            descriptionErrorLC.Text = string.Empty;
            descriptionErrorLC.LineColor = Color.Black;
            descriptionErrorLC.ForeColor = Color.Black;

            permissionErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            permissionErrorLC.Text = LABEL_MESSAGE_PERMISSION;
            permissionErrorLC.LineColor = Color.Black;
            permissionErrorLC.ForeColor = Color.Black;

            permissionSLUE.EditValue = null;
            permissionEIFS.Refresh();
            permissionEIFS.GetQueryable += PermissionEIFS_GetQueryable;
            roleBS.ResetBindings(true);
            roleBS.DataSource = new Data.ORM.Role();
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (nameTE.Name == field.Key)
                    {
                        nameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        nameErrorLC.Text = field.Value;
                        nameErrorLC.LineColor = Color.Red;
                        nameErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (descriptionME.Name == field.Key)
                    {
                        descriptionErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        descriptionErrorLC.Text = field.Value;
                        descriptionErrorLC.LineColor = Color.Red;
                        descriptionErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        permissionErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        permissionErrorLC.Text = field.Value;
                        permissionErrorLC.LineColor = Color.Red;
                        permissionErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (nameTE.Name == fields.First().Key)
                {
                    nameTE.Focus();
                }
                else if (descriptionME.Name == fields.First().Key)
                {
                    descriptionME.Focus();
                }
                else
                {
                    permissionSLUE.Focus();
                }
            }
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


        #region ActionsButtons
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var role = (Data.ORM.Role)roleBS.Current;

                var permissions = new List<Data.ORM.Permission>();
                int[] indexsPermissions = permissionSLUEV.GetSelectedRows();
                for (int i = 0; i < indexsPermissions.Length; i++)
                {
                    if (indexsPermissions[i] != -1)
                    {
                        permissions.Add((Data.ORM.Permission)permissionSLUEV.GetRow(indexsPermissions[i]));
                    }
                }
                role.Permissions = permissions;

                if (_isAddOrEdit)
                {
                    _cRole.EditRole(this, role);
                    _isCRoleAlive = true;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    _cRole.AddRole(this, role);

                    if (!_isFieldWithError)
                    {
                        RefreshView();
                        _isFieldWithError = false;
                    }
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cRole.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    acceptSB.Click += AcceptSB_Click;
                }
                else if (result == DialogResult.Abort)
                {
                    DialogResult = DialogResult.Abort;
                    Close();
                }
                else
                {
                    RefreshView();
                }
            }
        }

        private void CancelSB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cRole.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_isAddOrEdit)
            {
                if (result == DialogResult.Yes)
                {
                    _isCRoleAlive = true;
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    _isCRoleAlive = false;
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }
        #endregion


        private void V_AddEditRoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isCRoleAlive)
                Dispose();
            else
            {
                _cRole.Dispose();
                Dispose();
            }
        }
    }
}
