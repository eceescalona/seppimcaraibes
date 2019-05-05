namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;

    internal class Order
    {
        public Data.ORM.Order GetOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            return rOrder.GetOrder(context, code);
        }

        public void AddOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order)
        {
            var rOrder = new Data.Repository.OrderRepository();
            if (!context.Orders.Any(o => o.OrderId == order.OrderId))
            {
                rOrder.AddOrder(context, order);
            }
        }

        public void EditOrder(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Order order)
        {
            var rOrder = new Data.Repository.OrderRepository();
            rOrder.EditOrder(context, order);
        }

        public void DeleteOrder(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rOrder = new Data.Repository.OrderRepository();
            rOrder.DeleteOrder(context, code);
        }
    }
}
