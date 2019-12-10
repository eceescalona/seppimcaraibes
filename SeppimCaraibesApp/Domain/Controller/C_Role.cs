namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_Role : IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Role _mRole;


        public C_Role()
        {
            _mRole = new Model.Role();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Role role, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string message;
            string field;

            if (string.IsNullOrWhiteSpace(role.Name))
            {
                flag = false;
                field = "nameTE";
                message = "El Campo Nombre no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(role.Description))
            {
                flag = false;
                field = "descriptionTE";
                message = "El Campo Descripción no puede ser vacío.";
                fields.Add(field, message);
            }

            if (role.RolePermissions != null && role.RolePermissions.Count > 0)
            {
                flag = false;
                field = "permissionsSLUE";
                message = "Debe seleccionar al menos un permiso.";
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


        #region RoleManage
        public void AddRole(IAddEditRole addEditRole, Data.ORM.Role role)
        {
            string message = string.Format("El rol {0} ha sido registrado satisfactoriamente.", role.Name);

            if (Validate(role, out Dictionary<string, string> fields))
            {
                _mRole.AddRole(_context, role);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditRole.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditRole.ShowFieldsWithError(fields);
            }
        }

        public async void EditRole(IAddEditRole addEditRole, int code)
        {
            var role = await _mRole.GetRole(_context, code);
            addEditRole.EditRole(role);
        }

        public void EditRole(IAddEditRole addEditRole, Data.ORM.Role role)
        {
            string message = string.Format("Los atributos del rol {0} han sido modificados satisfactoriamente.", role.Name);

            if (Validate(role, out Dictionary<string, string> fields))
            {
                _mRole.EditRole(_context, role);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditRole.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditRole.ShowFieldsWithError(fields);
            }
        }

        public void DeleteRole(IListRoles listRole, int code)
        {
            string message = string.Format("El role con código {0} ha sido eliminado satisfactoriamente.", code);

            _mRole.DeleteRole(_context, code);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            listRole.ShowMessage(ETypeOfMessage.Information, message);
            listRole.RefreshView();
        }
        #endregion
    }
}
