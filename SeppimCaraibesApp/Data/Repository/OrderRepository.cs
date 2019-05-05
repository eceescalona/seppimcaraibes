namespace SeppimCaraibesApp.Data.Repository
{
    internal class OrderRepository
    {
        public ORM.Order GetOrder(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Orders.Find(code);
        }

        public void AddOrder(ORM.SeppimCaraibesLocalEntities context, ORM.Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void EditOrder(ORM.SeppimCaraibesLocalEntities context, ORM.Order order)
        {
            context.SaveChanges();
        }

        public void DeleteOrder(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var order = context.Orders.Find(code);
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
