namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Linq;

    internal class C_Order : IDisposable
    {
        private const string FV = "FV";
        private const string NC = "NC";
        private const string FIELD = "providerSLUE";
        private const string FIELD_MESSAGE = "El Campo Proveedor no puede ser vacío.";
        private const string SELECT_PROVIDER = "Uds. necesita seleccionar un proveedor para continuar.";

        private readonly Data.ORM.SeppimCaraibesLocalEntities _context;
        private readonly Model.Order _mOrder;


        public C_Order()
        {
            _mOrder = new Model.Order();
            _context = new Data.ORM.SeppimCaraibesLocalEntities();
        }


        #region IDisposable
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion


        private bool Validate(Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrders, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string message;
            string field;

            if (order.Date == null)
            {
                flag = false;
                field = "dateDE";
                message = "El Campo Fecha no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(order.CustomerReference))
            {
                flag = false;
                field = "customerReferenceTE";
                message = "El Campo Nombre no puede ser vacío.";
                fields.Add(field, message);
            }

            if (productsOrders == null || productsOrders.Count <= 0)
            {
                flag = false;
                field = "productsGC";
                message = "El Campo Productos no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(order.CustomerId))
            {
                flag = false;
                field = "customerSLUE";
                message = "El Campo Cliente no puede ser vacío.";
                fields.Add(field, message);
            }

            return flag;
        }

        private string OrderCode(DateTime date)
        {
            string back = "000";

            string orderCode = date.Year.ToString() + date.Month.ToString() + date.Day.ToString() + back;

            var order = _mOrder.GetLastOrderID(_context);
            if (string.IsNullOrWhiteSpace(order))
            {
                return orderCode;
            }
            else
            {
                long code = long.Parse(order) + 1;
                orderCode = code.ToString();
                return orderCode;
            }
        }

        private string Message(params object[] value)
        {
            return string.Format("La orden {0} ha sido registrado satisfactoriamente.", value);
        }


        public string GetInvoiceReference(Data.ORM.Order order)
        {
            string back = "000";

            string invoiceReference = DateTime.Now.Year.ToString() + back;

            var orders = _context.Orders.ToList();

            if (orders.Count == 1)
            {
                if (order.CommercialValue == ECommercialValue.FV)
                {
                    return FV + invoiceReference;
                }
                else
                {
                    return NC + invoiceReference;
                }
            }
            else if (orders.Count > 1)
            {
                var lastOrderSubOne = orders[orders.Count - 2];

                if (order.CommercialValue == ECommercialValue.FV)
                {
                    long code = long.Parse(lastOrderSubOne.InvoiceReference) + 1;
                    invoiceReference = code.ToString();
                    return FV + invoiceReference;
                }
                else
                {
                    long code = long.Parse(lastOrderSubOne.InvoiceReference) + 1;
                    invoiceReference = code.ToString();
                    return NC + invoiceReference;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
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

        public void LoadReport(IReport reportQuote, string code)
        {
            var reportData = _mOrder.GetOrderReportView(_context, code);
            reportQuote.LoadData(reportData);
        }


        #region OrderManage
        public void AddOrder(IAddEditOrder addEditOrder, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrders)
        {

            if (Validate(order, productsOrders, out Dictionary<string, string> fields))
            {
                order.OrderId = OrderCode(order.Date.GetValueOrDefault());

                _mOrder.AddOrder(_context, order, productsOrders);

                C_Log _cLog = new C_Log();
                _cLog.Write(Message(new object[] { order.OrderId }), ETypeOfMessage.Information);

                addEditOrder.ShowMessage(ETypeOfMessage.Information, Message(new object[] { order.OrderId }));
                addEditOrder.RefreshView();
            }
            else
            {
                addEditOrder.ShowFieldsWithError(fields);
            }
        }

        public void SetProviderOrder(ISelectProvider selectProvider, string code, Data.ORM.Provider provider)
        {
            string message = string.Format("El proveedor {0} ha sido selccionado satisfactoriamente para la orden {1}.", provider.ProviderName, code);

            if (provider != null)
            {
                _mOrder.SetProviderOrder(_context, code, provider);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                selectProvider.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                selectProvider.ShowFieldsWithError(FIELD, FIELD_MESSAGE);
            }
        }

        public void EditOrder(IAddEditOrder addEditOrder, string code)
        {
            var order = _mOrder.GetOrder(_context, code);
            addEditOrder.EditOrder(order);
        }

        public void EditOrder(IAddEditOrder addEditOrder, Data.ORM.Order order)
        {
            string message = string.Format("Los atributos de la orden {0} han sido modificados satisfactoriamente.", order.OrderId);

            _mOrder.EditOrder(_context, order);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            addEditOrder.ShowMessage(ETypeOfMessage.Information, message);
        }

        public void EditOrder(IAddEditOrder addEditOrder, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrders)
        {
            string message = string.Format("Los atributos de la orden {0} han sido modificados satisfactoriamente.", order.OrderId);

            if (Validate(order, productsOrders, out Dictionary<string, string> fields))
            {
                _mOrder.EditOrder(_context, order, productsOrders);

                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                addEditOrder.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditOrder.ShowFieldsWithError(fields);
            }
        }

        public void EditOrder(IListOrders listOrders, string code, EOrderProcessState orderProcessState)
        {
            string message = string.Format("Los atributos de la orden {0} han sido modificados satisfactoriamente.", code);

            if (!(_mOrder.EditOrder(_context, code, orderProcessState)))
            {
                listOrders.ShowMessage(ETypeOfMessage.Warning, SELECT_PROVIDER);
            }
            else
            {
                C_Log _cLog = new C_Log();
                _cLog.Write(message, ETypeOfMessage.Information);

                listOrders.ShowMessage(ETypeOfMessage.Information, message);
                listOrders.RefreshView();
            }
        }

        public void EditOrder(IListOrders listOrders, string code, EInvoiceState invoiceState)
        {
            string message = string.Format("Los atributos de la orden {0} han sido modificados satisfactoriamente.", code);

            _mOrder.EditOrder(_context, code, invoiceState);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            listOrders.ShowMessage(ETypeOfMessage.Information, message);
            listOrders.RefreshView();
        }

        public void DeleteOrder(IListOrders listOrders, string code)
        {
            string message = string.Format("La orden con código {0} ha sido eliminado satisfactoriamente.", code);

            _mOrder.DeleteOrder(_context, code);

            C_Log _cLog = new C_Log();
            _cLog.Write(message, ETypeOfMessage.Information);

            listOrders.ShowMessage(ETypeOfMessage.Information, message);
            listOrders.RefreshView();
        }

        public bool ValidateProvider(string code)
        {
            var order = _mOrder.GetOrder(_context, code);

            if (string.IsNullOrWhiteSpace(order.ProviderId))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
