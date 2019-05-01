namespace SeppimCaraibesApp.Data.Repository
{
    internal class CustomerRepository
    {
        public ORM.Customer GetCustomer(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Customers.Find(code);
        }

        public void AddCustomer(ORM.SeppimCaraibesLocalEntities context, ORM.Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void EditCustomer(ORM.SeppimCaraibesLocalEntities context, ORM.Customer customer)
        {
            context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCustomer(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var customer = context.Customers.Find(code);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
