namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_User : IDisposable
    {
        private const string PASS = "Not Change";
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.User _mUser;


        public C_User()
        {
            _mUser = new Model.User();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.User user, string copyPassword, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string message;
            string field;

            if (string.IsNullOrWhiteSpace(user.Nick))
            {
                flag = false;
                field = "nickTE";
                message = "El Campo Usuario no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                flag = false;
                field = "passwordTE";
                message = "El Campo Contraseña no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(copyPassword))
            {
                flag = false;
                field = "copyPassTE";
                message = "El Campo Repetir Contraseña no puede ser vacío.";
                fields.Add(field, message);
            }
            else 
            {
                if (!copyPassword.Equals(PASS))
                {
                    if (!copyPassword.Equals(user.Password))
                    {
                        flag = false;
                        field = "copyPassTE";
                        message = "El Campo Repetir Contraseña debe ser igual a Contraseña.";
                        fields.Add(field, message);
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(user.FullName))
            {
                flag = false;
                field = "fullNameTE";
                message = "El Campo Nombre Completo no puede ser vacío.";
                fields.Add(field, message);
            }

            if (user.RoleId < 0)
            {
                flag = false;
                field = "roleSLUE";
                message = "El Campo Rol no puede ser vacío.";
                fields.Add(field, message);

                return flag;
            }
            return flag;
        }


        public Data.ORM.SeppimCaraibesLocalEntities GetContext()
        {
            return _context;
        }

        public string GetEnumDescription(Enum value)
        {
            FieldInfo fielInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] descriptionAttributes = (DescriptionAttribute[])fielInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes != null && descriptionAttributes.Length > 0)
            {
                return descriptionAttributes[0].Description;
            }
            else
            {
                return string.Empty;
            }
        }


        #region UserManage
        public void AddUser(IAddEditUser addEditUser, Data.ORM.User user, string copyPassword)
        {
            string message = string.Format("El usuario {0} ha sido registrado satisfactoriamente.", user.Nick);

            if (Validate(user, copyPassword, out Dictionary<string, string> fields))
            {
                _mUser.AddUser(_context, user);
                addEditUser.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditUser.ShowFieldsWithError(fields);
            }
        }

        public async void EditUser(IAddEditUser addEditUser, int code)
        {
            var user = await _mUser.GetUser(_context, code);
            addEditUser.EditUser(user);
        }

        public void EditUser(IAddEditUser addEditUser, Data.ORM.User user)
        {
            string message = string.Format("Los atributos del usuario {0} han sido modificados satisfactoriamente.", user.Nick);

            if (Validate(user, PASS, out Dictionary<string, string> fields))
            {
                _mUser.EditUser(_context, user);
                addEditUser.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditUser.ShowFieldsWithError(fields);
            }
        }

        public void EditUser(IAddEditUser addEditUser, Data.ORM.User user, string copyPassword)
        {
            string message = string.Format("Los atributos del usuario {0} han sido modificados satisfactoriamente.", user.Nick);

            if (Validate(user, copyPassword, out Dictionary<string, string> fields))
            {
                _mUser.EditUser(_context, user);
                addEditUser.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditUser.ShowFieldsWithError(fields);
            }
        }

        public void DeleteUser(IListUsers listUsers, int code)
        {
            string message = string.Format("El usuario con código {0} ha sido eliminado satisfactoriamente.", code);

            _mUser.DeleteUser(_context, code);
            listUsers.ShowMessage(ETypeOfMessage.Information, message);
            listUsers.RefreshView();
        }
        #endregion
    }
}
