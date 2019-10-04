namespace SeppimCaraibesApp.Domain.View.User
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    internal partial class V_AddEditUserForm : Form, Controller.IAddEditUser
    {
        private const string NAME_FORM_ADD = "Registrar Usuario";
        private const string LABEL_MESSAGE_ROLE = "Debe seleccionar un rol";
        private const string NAME_FORM_EDIT = "Editar Usuario";
        private const string MESSAGE_ERROR = "Ha ocurrido un error; por favor vuelva a intentarlo. Si el error persiste cierre el formulario y " +
            "vuelva a abrirlo. Gracias y disculpe las molestias.";
        private const string CANCEL_MESSAGE = "Si no guarda, perderá los datos introducidos. ¿Desea continuar?";

        private readonly Controller.C_User _cUser;
        private readonly bool _isAddOrEdit;
        private readonly bool _changePassword;
        private bool _isCUserAlive;
        private bool _isFieldWithError;
        private int _idRole;


        #region Ctor
        public V_AddEditUserForm(Controller.C_User cUser)
        {
            InitializeComponent();
            Text = NAME_FORM_ADD;

            _cUser = cUser;
            _isCUserAlive = true;
            _isAddOrEdit = false;
            _isFieldWithError = false;
            _idRole = -1;
            _changePassword = false;

            userBS.DataSource = new Data.ORM.User();
            roleEIFBS.GetQueryable += RoleEIFBS_GetQueryable;
        }

        public V_AddEditUserForm(Controller.C_User cUser, int idRol)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cUser = cUser;
            _isCUserAlive = true;
            _isAddOrEdit = true;
            _isFieldWithError = false;

            _idRole = idRol;
            roleSLUE.Enabled = false;

            _changePassword = false;

            userBS.DataSource = new Data.ORM.User();
            roleEIFBS.GetQueryable += RoleEIFBS_GetQueryable;
        }

        public V_AddEditUserForm(Controller.C_User cUser, int code, bool changePassword)
        {
            InitializeComponent();
            Text = NAME_FORM_EDIT;

            _cUser = cUser;
            _isCUserAlive = true;
            _isAddOrEdit = true;
            _isFieldWithError = false;
            _idRole = -1;
            _changePassword = changePassword;

            if (_changePassword)
            {
                nickTE.Enabled = false;
                fullNameTE.Enabled = false;
                emailTE.Enabled = false;
                phoneTE.Enabled = false;
                roleSLUE.Enabled = false;
            }

            _cUser.EditUser(this, code);
            roleEIFBS.GetQueryable += RoleEIFBS_GetQueryable;
        }
        #endregion


        private void RoleEIFBS_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            Data.ORM.SeppimCaraibesLocalEntities dataContext = _cUser.GetContext();
            e.QueryableSource = dataContext.Roles;
        }


        #region IAddEditUser
        public void EditUser(Data.ORM.User user)
        {
            userBS.DataSource = user;
            if (user.RoleId >= 0)
            {
                _idRole = user.RoleId;
                roleSLUE.EditValue = _idRole;
            }
        }

        public void RefreshView()
        {
            nickTE.Text = string.Empty;
            fullNameTE.Text = string.Empty;
            passwordTE.Text = string.Empty;
            copyPassTE.Text = string.Empty;
            phoneTE.Text = string.Empty;
            emailTE.Text = string.Empty;

            nickErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            nickErrorLC.Text = string.Empty;
            nickErrorLC.LineColor = Color.Black;
            nickErrorLC.ForeColor = Color.Black;

            fullNameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            fullNameErrorLC.Text = string.Empty;
            fullNameErrorLC.LineColor = Color.Black;
            fullNameErrorLC.ForeColor = Color.Black;

            passwordErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            passwordErrorLC.Text = string.Empty;
            passwordErrorLC.LineColor = Color.Black;
            passwordErrorLC.ForeColor = Color.Black;

            copyPassErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            copyPassErrorLC.Text = string.Empty;
            copyPassErrorLC.LineColor = Color.Black;
            copyPassErrorLC.ForeColor = Color.Black;

            roleErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
            roleErrorLC.Text = LABEL_MESSAGE_ROLE;
            roleErrorLC.LineColor = Color.Black;
            roleErrorLC.ForeColor = Color.Black;

            roleSLUE.EditValue = null;
            roleEIFBS.Refresh();
            roleEIFBS.GetQueryable += RoleEIFBS_GetQueryable;
            userBS.ResetBindings(true);
            userBS.DataSource = new Data.ORM.User();
        }

        public void ShowFieldsWithError(Dictionary<string, string> fields)
        {
            if (fields != null && fields.Count > 0)
            {
                foreach (var field in fields)
                {
                    if (nickTE.Name == field.Key)
                    {
                        nickErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        nickErrorLC.Text = field.Value;
                        nickErrorLC.LineColor = Color.Red;
                        nickErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (passwordTE.Name == field.Key)
                    {
                        passwordErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        passwordErrorLC.Text = field.Value;
                        passwordErrorLC.LineColor = Color.Red;
                        passwordErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (copyPassTE.Name == field.Key)
                    {
                        copyPassErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        copyPassErrorLC.Text = field.Value;
                        copyPassErrorLC.LineColor = Color.Red;
                        copyPassErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else if (fullNameTE.Name == field.Key)
                    {
                        fullNameErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        fullNameErrorLC.Text = field.Value;
                        fullNameErrorLC.LineColor = Color.Red;
                        fullNameErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                    else
                    {
                        roleErrorLC.LookAndFeel.UseDefaultLookAndFeel = false;
                        roleErrorLC.Text = field.Value;
                        roleErrorLC.LineColor = Color.Red;
                        roleErrorLC.ForeColor = Color.Red;

                        _isFieldWithError = true;
                    }
                }

                if (nickTE.Name == fields.First().Key)
                {
                    nickTE.Focus();
                }
                else if (passwordTE.Name == fields.First().Key)
                {
                    passwordTE.Focus();
                }
                else if (copyPassTE.Name == fields.First().Key)
                {
                    copyPassTE.Focus();
                }
                else if (fullNameTE.Name == fields.First().Key)
                {
                    fullNameTE.Focus();
                }
                else
                {
                    roleSLUE.Focus();
                }
            }
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


        #region ActionsButtons
        private void AcceptSB_Click(object sender, EventArgs e)
        {
            try
            {
                var user = (Data.ORM.User)userBS.Current;

                var role = (Data.ORM.Role)roleSLUEV.GetFocusedRow();
                user.RoleId = role.RoleId;
                user.Role = role;

                if (_isAddOrEdit)
                {
                    if (_changePassword)
                    {
                        _cUser.EditUser(this, user, copyPassTE.Text);
                    }
                    else
                    {
                        _cUser.EditUser(this, user);
                    }

                    _isCUserAlive = true;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    _cUser.AddUser(this, user, copyPassTE.Text);

                    if (!_isFieldWithError)
                    {
                        RefreshView();
                        _isFieldWithError = false;
                    }
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(MESSAGE_ERROR, _cUser.GetEnumDescription(ETypeOfMessage.Error), MessageBoxButtons.AbortRetryIgnore,
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
            DialogResult result = MessageBox.Show(CANCEL_MESSAGE, _cUser.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_isAddOrEdit)
            {
                if (result == DialogResult.Yes)
                {
                    _isCUserAlive = true;
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    _isCUserAlive = false;
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }

        private void CloseSB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uds. a terminado, la ventana cerrará.", _cUser.GetEnumDescription(ETypeOfMessage.Warning), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion


        private void V_AddEditUserForm_FormClosed(object sender, FormClosedEventArgs e)
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
