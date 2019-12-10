namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Net.Mail;
    using System.Reflection;

    internal class C_Provider : IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Provider _mProvider;


        public C_Provider()
        {
            _mProvider = new Model.Provider();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Provider provider, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string field;
            string message;

            if (string.IsNullOrWhiteSpace(provider.ProviderId))
            {
                flag = false;
                field = "codeTE";
                message = "El Campo Código no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(provider.ProviderName))
            {
                flag = false;
                field = "nameTE";
                message = "El Campo Nombre Completo no puede ser vacío.";
                fields.Add(field, message);
            }

            if (!string.IsNullOrWhiteSpace(provider.ProviderEmail))
            {
                try
                {
                    MailAddress mail = new MailAddress(provider.ProviderEmail);
                }
                catch (Exception)
                {
                    flag = false;
                    field = "emailTE";
                    message = "El Campo Correo Electrónico no tiene el formato adecuado.";
                    fields.Add(field, message);
                }
            }

            if (provider.Products == null)
            {
                flag = false;
                field = "productsGridC";
                message = "El Campo Productos no puede ser vacío.";
                fields.Add(field, message);
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


        #region ProviderManage
        public void AddProvider(IAddEditProvider addEditProvider, Data.ORM.Provider provider)
        {
            string message = string.Format("El proveedor {0} ha sido registrado satisfactoriamente.", provider.ProviderName);

            if (Validate(provider, out Dictionary<string, string> fields))
            {
                _mProvider.AddProvider(_context, provider);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditProvider.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditProvider.ShowFieldsWithError(fields);
            }
        }

        public async void EditProvider(IAddEditProvider addEditProvider, string code)
        {
            var provider = await _mProvider.GetProvider(_context, code);
            addEditProvider.EditProvider(provider);
        }

        public void EditProvider(IAddEditProvider addEditProvider, Data.ORM.Provider provider)
        {
            string message = string.Format("Los atributos del proveedor {0} han sido modificados satisfactoriamente.", provider.ProviderName);

            if (Validate(provider, out Dictionary<string, string> fields))
            {
                _mProvider.EditProvider(_context, provider);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditProvider.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditProvider.ShowFieldsWithError(fields);
            }
        }

        public void DeleteProvider(IListProviders listProviders, string code)
        {
            string message = string.Format("El proveedor con código {0} ha sido eliminado satisfactoriamente.", code);

            _mProvider.DeleteProvider(_context, code);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            listProviders.ShowMessage(ETypeOfMessage.Information, message);
            listProviders.RefreshView();
        }
        #endregion
    }
}
