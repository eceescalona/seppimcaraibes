namespace SeppimCaraibesApp.Domain.Model
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Order
    {
        public Data.ORM.Order GetOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            return rOrder.GetOrder(context, code);
        }

        public void AddOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order, List<Data.ORM.ProductsOrdersView> productsOrdersViews)
        {
            var rOrder = new Data.Repository.OrderRepository();
            if (!context.Orders.Any(o => o.OrderId == order.OrderId))
            {
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

                rOrder.AddOrder(context, order);
            }
        }

        public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order, List<Data.ORM.ProductsOrdersView> productsOrdersViews)
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

        public void DeleteOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            rOrder.DeleteOrder(context, code);
        }
    }
}
