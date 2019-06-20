namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_Permission : IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Permission _mPermission;


        public C_Permission()
        {
            _mPermission = new Model.Permission();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Permission permission, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string message;
            string field;

            if (string.IsNullOrWhiteSpace(permission.Name))
            {
                flag = false;
                field = "nameTE";
                message = "El Campo Nombre no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(permission.Description))
            {
                flag = false;
                field = "descriptionTE";
                message = "El Campo Descripción no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(permission.Group))
            {
                flag = false;
                field = "groupLUE";
                message = "El Campo Grupo no puede ser vacío.";
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


        #region PermissionManage
        public void AddPermission(IAddEditPermission addEditPermission, Data.ORM.Permission permission)
        {
            string message = string.Format("El permiso {0} ha sido registrado satisfactoriamente.", permission.Name);

            if (Validate(permission, out Dictionary<string, string> fields))
            {
                _mPermission.AddPermission(_context, permission);
                addEditPermission.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditPermission.ShowFieldsWithError(fields);
            }
        }

        public async void EditPermission(IAddEditPermission addEditPermission, int code)
        {
            var permission = await _mPermission.GetPermission(_context, code);
            addEditPermission.EditPermission(permission);
        }

        public void EditPermission(IAddEditPermission addEditPermission, Data.ORM.Permission permission)
        {
            string message = string.Format("Los atributos del permiso {0} han sido modificados satisfactoriamente.", permission.Name);

            if (Validate(permission, out Dictionary<string, string> fields))
            {
                _mPermission.EditPermission(_context, permission);
                addEditPermission.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditPermission.ShowFieldsWithError(fields);
            }
        }

        public void DeletePermission(IListPermissions listPermission, int code)
        {
            string message = string.Format("El permiso con código {0} ha sido eliminado satisfactoriamente.", code);

            _mPermission.DeletePermission(_context, code);
            listPermission.ShowMessage(ETypeOfMessage.Information, message);
            listPermission.RefreshView();
        }
        #endregion
    }
}
