namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;
    using System.Linq;

    internal class OrderRepository
    {
        public ORM.Order GetOrder(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var order = context.Orders.SingleOrDefault(o => o.OrderId.Equals(code));
            return order;
        }

        public ORM.Order GetLastOrder(ORM.SeppimCaraibesLocalEntities context)
        {
            var orders = context.Orders.ToList();
            if (orders.Count < 1)
            {
                return null;
            }
            else if (orders.Count == 1)
            {
                return orders[0];
            }
            else
            {
                return orders[orders.Count - 1];
            }
        }

        public void AddOrder(ORM.SeppimCaraibesLocalEntities context, ORM.Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            context.Entry(order).Reload();
        }

        public async void SetProviderOrder(ORM.SeppimCaraibesLocalEntities context, string code, ORM.Provider provider)
        {
            var order = await context.Orders.FindAsync(code);
            order.ProviderId = provider.ProviderId;
            context.SaveChanges();
            context.Entry(order).Reload();
        }

        public void EditOrder(ORM.SeppimCaraibesLocalEntities context, ORM.Order order)
        {
            context.Orders.Add(order);
            context.Entry(order).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(order).Reload();
        }

        public async void DeleteOrder(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var order = await context.Orders.FindAsync(code);
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
