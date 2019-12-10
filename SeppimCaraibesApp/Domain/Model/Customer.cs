namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;
    using System.Threading.Tasks;

    internal class Customer
    {
        public async Task<Data.ORM.Customer> GetCustomer(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rCustomer = new Data.Repository.CustomerRepository();
            return await rCustomer.GetCustomer(context, code);
        }

        public void AddCustomer(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Customer customer)
        {
            var rCustomer = new Data.Repository.CustomerRepository();
            if (!context.Customers.Any(c => c.CustomerId == customer.CustomerId))
            {
                rCustomer.AddCustomer(context, customer);
            }
        }

        public void EditCustomer(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Customer customer)
        {
            var rCustomer = new Data.Repository.CustomerRepository();
            rCustomer.EditCustomer(context, customer);
        }

        public void DeleteCustomer(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rCustomer = new Data.Repository.CustomerRepository();
            rCustomer.DeleteCustomer(context, code);
        }
    }
}
