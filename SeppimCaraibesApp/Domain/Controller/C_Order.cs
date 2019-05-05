namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_Order : IDisposable
    {
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


        private bool Validate(Data.ORM.Order order, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string field = string.Empty;
            string message = string.Empty;

            if (string.IsNullOrWhiteSpace(order.OrderId))
            {
                flag = false;
                field = "codeTE";
                message = "El Campo Código no puede ser vacío.";
                fields.Add(field, message);
            }

            if (string.IsNullOrWhiteSpace(order.CustomerId))
            {
                flag = false;
                field = "nameME";
                message = "El Campo Nombre no puede ser vacío.";
                fields.Add(field, message);
            }

            if (order.ProductsOrders == null)
            {
                flag = false;
                field = "providersGridC";
                message = "El Campo Proveedor no puede ser vacío.";
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


        #region OrderManage
        public void AddOrder(IAddEditOrder addEditOrder, Data.ORM.Order order)
        {
            string message = string.Format("La orden {0} ha sido registrado satisfactoriamente.", order.OrderId);

            if (Validate(order, out Dictionary<string, string> fields))
            {
                _mOrder.AddOrder(_context, order);
                addEditOrder.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditOrder.ShowFieldsWithError(fields);
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

            if (Validate(order, out Dictionary<string, string> fields))
            {
                _mOrder.EditOrder(_context, order);
                addEditOrder.ShowMessage(ETypeOfMessage.Information, message);
            }
            else
            {
                addEditOrder.ShowFieldsWithError(fields);
            }
        }

        public void DeleteOrder(IListOrders listOrders, string code)
        {
            string message = string.Format("La orden con código {0} ha sido eliminado satisfactoriamente.", code);

            _mOrder.DeleteOrder(_context, code);
            listOrders.ShowMessage(ETypeOfMessage.Information, message);
            listOrders.RefreshView();
        }
        #endregion
    }
}
