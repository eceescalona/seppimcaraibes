namespace SeppimCaraibesApp.Domain.Model
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Order
    {
        public Data.ORM.Order GetOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            var order = rOrder.GetOrder(context, code);

            if (order != null)
            {
                if (context.ProductsOrders.Any(po => po.OrderId == order.OrderId))
                {
                    order.ProductsOrders = context.ProductsOrders.Where(po => po.OrderId == order.OrderId).ToList();
                }
            }

            return order;
        }

        public void AddOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrdersViews)
        {
            var rOrder = new Data.Repository.OrderRepository();
            if (!context.Orders.Any(o => o.OrderId == order.OrderId))
            {
                foreach (var product in productsOrdersViews)
                {
                    var productOrder = new Data.ORM.ProductsOrder
                    {
                        OrderId = order.OrderId,
                        ProductId = product.ProductId,
                        Qty = product.Qty,
                        Discount = product.Discount,
                        Interests = product.Interests
                    };

                    order.ProductsOrders.Add(productOrder);
                }

                rOrder.AddOrder(context, order);
            }
        }

        public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order, List<Data.POCO.ProductsOrders> productsOrdersViews)
        {
            var rOrder = new Data.Repository.OrderRepository();

            var productsOrders = new List<Data.ORM.ProductsOrder>();
            foreach (var product in productsOrdersViews)
            {
                var productOrder = new Data.ORM.ProductsOrder
                {
                    OrderId = order.OrderId,
                    ProductId = product.ProductId,
                    Qty = product.Qty,
                    Discount = product.Discount,
                    Interests = product.Interests
                };

                productsOrders.Add(productOrder);
            }
            order.ProductsOrders = productsOrders;

            rOrder.EditOrder(context, order);
        }

        public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code, EOrderProcessState orderProcessState)
        {
            var rOrder = new Data.Repository.OrderRepository();

            var order = rOrder.GetOrder(context, code);
            order.OrderProcessState = orderProcessState;

            rOrder.EditOrder(context, order);
        }

        public void DeleteOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            rOrder.DeleteOrder(context, code);
        }
    }
}
