﻿namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
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

        public T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);

            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "description");
        }


        #region UserManage
        public void AddUser(IAddEditUser addEditUser, Data.ORM.User user, string copyPassword)
        {
            string message = string.Format("El usuario {0} ha sido registrado satisfactoriamente.", user.Nick);

            if (Validate(user, copyPassword, out Dictionary<string, string> fields))
            {
                _mUser.AddUser(_context, user);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

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

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

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

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditUser.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditUser.ShowFieldsWithError(fields);
            }
        }

        public async void DisableUser(IListUsers listUsers, int code, string message)
        {
            var user = await _mUser.GetUser(_context, code);
            user.Enable = false;
            user.NotEnableCause = message;

            string description = string.Format("El usuario {0} fue inhabilitado.", user.Nick);

            _mUser.EditUser(_context, user);

            C_Log _cLog = new C_Log();
            _cLog.Write(description, ETypeOfMessage.Information);

            listUsers.ShowMessage(ETypeOfMessage.Information, description);
            listUsers.RefreshView();
        }

        public async void EnableUser(IListUsers listUsers, int code)
        {
            var user = await _mUser.GetUser(_context, code);
            user.Enable = true;

            string description = string.Format("El usuario {0} fue habilitado.", user.Nick);

            _mUser.EditUser(_context, user);

            C_Log _cLog = new C_Log();
            _cLog.Write(description, ETypeOfMessage.Information);

            listUsers.ShowMessage(ETypeOfMessage.Information, description);
            listUsers.RefreshView();
        }

        public async void ShowDisableCause(IListUsers listUsers, int code)
        {
            var user = await _mUser.GetUser(_context, code);
            listUsers.ShowMessage(ETypeOfMessage.Information, user.NotEnableCause);
        }

        public void DeleteUser(IListUsers listUsers, int code)
        {
            string message = string.Format("El usuario con código {0} ha sido eliminado satisfactoriamente.", code);

            _mUser.DeleteUser(_context, code);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            listUsers.ShowMessage(ETypeOfMessage.Information, message);
            listUsers.RefreshView();
        }
        #endregion


        #region UserControl
        private bool ValidateUser(string nick, string password, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string message;
            string field;

            if (string.IsNullOrWhiteSpace(nick))
            {
                flag = false;
                field = "nickTE";
                message = "El Campo Usuario no puede ser vacío.";
                fields.Add(field, message);
            }
            else
            {
                if (!_context.Users.Any(u => u.Nick == nick))
                {
                    flag = false;
                    field = "nickTE";
                    message = "El Campo Usuario es incorrecto.";
                    fields.Add(field, message);
                }
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                flag = false;
                field = "passwordTE";
                message = "El Campo Contraseña no puede ser vacío.";
                fields.Add(field, message);
            }
            else
            {
                if (!_context.Users.Any(u => u.Password == password))
                {
                    flag = false;
                    field = "nickTE";
                    message = "El Campo Contraseña es incorrecto.";
                    fields.Add(field, message);
                }
            }

            return flag;
        }

        public void Loggin(IControlUser control, string nick, string password)
        {
            string message = string.Format("Repita, uno de los valores es incorrecto. {0} | {1}", nick, password);

            if (ValidateUser(nick, password, out Dictionary<string, string> fields))
            {
                var user = _mUser.GetUser(_context, nick, password);
                if (user != null)
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(string.Format("El usurio {0} ha entrado en el sistema.", nick), ETypeOfMessage.Information);

                    control.DisplayMain(user);
                }
                else
                {
                    C_Log _cLog = new C_Log();
                    _cLog.Write(message, ETypeOfMessage.Warning);

                    control.ShowMessage(ETypeOfMessage.Warning, message);
                }
            }
            else
            {
                control.ShowFieldsWithError(fields);
            }
        }

        public void SetLogginUser(Data.ORM.User user)
        {
            UserLog.Instance.SetUserId = user.UserId;
            UserLog.Instance.SetNick = user.Nick;
            UserLog.Instance.SetPassword = user.Password;
            UserLog.Instance.SetFullName = user.FullName;
            UserLog.Instance.SetRoleId = user.RoleId;
            UserLog.Instance.SetRole = user.Role;
        }

        public void LogOff(IControlUser control)
        {
            string message = string.Format("{0} ha cerrado sesión.", UserLog.Instance.FullName);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            UserLog.Dispose();
            control.ShowMessage(ETypeOfMessage.Warning, message);
            control.LogOff();
        }
        #endregion
    }
}
