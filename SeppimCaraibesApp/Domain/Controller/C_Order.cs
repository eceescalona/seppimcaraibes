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


        private bool Validate(Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrders, out Dictionary<string, string> fields)
        {
            fields = new Dictionary<string, string>();
            bool flag = true;
            string field = string.Empty;
            string message = string.Empty;

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
            var random = new Random();
            int units = random.Next(0, 9);
            int dozens = random.Next(0, 9);
            int hundreds = random.Next(0, 9);

            string back = hundreds.ToString() + dozens.ToString() + units.ToString();

            string orderCode = date.Year.ToString() + date.Month.ToString() + date.Day.ToString() + back;


            var order = _mOrder.GetOrder(_context, orderCode);
            if (order == null)
            {
                return orderCode;
            }
            else
            {
                return OrderCode(date);
            }
        }

        private string Message(params object[] value)
        {
            return string.Format("La orden {0} ha sido registrado satisfactoriamente.", value);
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
        public void AddOrder(IAddEditOrder addEditOrder, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrders)
        {

            if (Validate(order, productsOrders, out Dictionary<string, string> fields))
            {
                order.OrderId = OrderCode(order.Date.GetValueOrDefault());

                _mOrder.AddOrder(_context, order, productsOrders);

                addEditOrder.ShowMessage(ETypeOfMessage.Information, Message(new object[] { order.OrderId }));
                addEditOrder.RefreshView();
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

        public void EditOrder(IAddEditOrder addEditOrder, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrders)
        {
            string message = string.Format("Los atributos de la orden {0} han sido modificados satisfactoriamente.", order.OrderId);

            if (Validate(order, productsOrders, out Dictionary<string, string> fields))
            {
                _mOrder.EditOrder(_context, order, productsOrders);
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

            _mOrder.EditOrder(_context, code, orderProcessState);
            listOrders.ShowMessage(ETypeOfMessage.Information, message);
            listOrders.RefreshView();
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
