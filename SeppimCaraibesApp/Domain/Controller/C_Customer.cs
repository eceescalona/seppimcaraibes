namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Net.Mail;
    using System.Reflection;

    internal class C_Customer : IDisposable
    {
        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Customer _mCustomer;


        public C_Customer()
        {
            _mCustomer = new Model.Customer();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Customer customer, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string field;
            string message;

            if (string.IsNullOrWhiteSpace(customer.CustomerId))
            {
                flag = false;
                field = "codeTE";
                message = "El Campo Código no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                flag = false;
                field = "nameTE";
                message = "El Campo Nombre Completo no puede ser vacío.";
                fields.Add(field, message);
            }

            if (!string.IsNullOrWhiteSpace(customer.CustomerEmail))
            {
                try
                {
                    MailAddress mail = new MailAddress(customer.CustomerEmail);
                }
                catch (Exception)
                {
                    flag = false;
                    field = "emailTE";
                    message = "El Campo Correo Electrónico no tiene el formato adecuado.";
                    fields.Add(field, message);
                }
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


        #region CustomerManage
        public void AddCustomer(IAddEditCustomer addEditCustomer, Data.ORM.Customer customer)
        {
            string message = string.Format("El cliente {0} ha sido registrado satisfactoriamente.", customer.CustomerName);

            if (Validate(customer, out Dictionary<string, string> fields))
            {
                _mCustomer.AddCustomer(_context, customer);
                addEditCustomer.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditCustomer.ShowFieldsWithError(fields);
            }
        }

        public async void EditCustomer(IAddEditCustomer addEditCustomer, string code)
        {
            var customer = await _mCustomer.GetCustomer(_context, code);
            addEditCustomer.EditCustomer(customer);
        }

        public void EditCustomer(IAddEditCustomer addEditCustomer, Data.ORM.Customer customer)
        {
            string message = string.Format("Los atributos del cliente {0} han sido modificados satisfactoriamente.", customer.CustomerName);

            if (Validate(customer, out Dictionary<string, string> fields))
            {
                _mCustomer.EditCustomer(_context, customer);
                addEditCustomer.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditCustomer.ShowFieldsWithError(fields);
            }
        }

        public void DeleteCustomer(IListCustomers listCustomers, string code)
        {
            string message = string.Format("El cliente con código {0} ha sido eliminado satisfactoriamente.", code);

            _mCustomer.DeleteCustomer(_context, code);
            listCustomers.ShowMessage(ETypeOfMessage.Information, message);
            listCustomers.RefreshView();
        }
        #endregion
    }
}
