namespace SeppimCaraibesApp.Data.Repository
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    internal class ProductRepository
    {
        public List<ORM.Product> GetProducts(ORM.SeppimCaraibesLocalEntities context)
        {
            return context.Products.ToList();
        }

        public async Task<ORM.Product> GetProduct(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return await context.Products.FindAsync(code);
        }

        public void AddProduct(ORM.SeppimCaraibesLocalEntities context, ORM.Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            context.Entry(product).Reload();
        }

        public void EditProduct(ORM.SeppimCaraibesLocalEntities context, ORM.Product product)
        {
            context.Products.Add(product);
            context.Entry(product).State = EntityState.Modified;
            context.SaveChanges();
            context.Entry(product).Reload();
        }

        public async void DeleteProduct(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var product = await context.Products.FindAsync(code);
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
