namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class CustomerRepository
    {
        public async Task<ORM.Customer> GetCustomer(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return await context.Customers.FindAsync(code);
        }

        public void AddCustomer(ORM.SeppimCaraibesLocalEntities context, ORM.Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            context.Entry(customer).Reload();
        }

        public void EditCustomer(ORM.SeppimCaraibesLocalEntities context, ORM.Customer customer)
        {
            context.Customers.Add(customer);
            context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(customer).Reload();
        }

        public async void DeleteCustomer(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var customer = await context.Customers.FindAsync(code);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
