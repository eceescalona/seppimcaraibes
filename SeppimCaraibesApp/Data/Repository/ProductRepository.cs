namespace SeppimCaraibesApp.Data.Repository
{
    internal class ProductRepository
    {
        public ORM.Product GetProduct(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Products.Find(code);
        }

        public void AddProduct(ORM.SeppimCaraibesLocalEntities context, ORM.Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void EditProduct(ORM.SeppimCaraibesLocalEntities context, ORM.Product product)
        {
            context.SaveChanges();
        }

        public void DeleteProduct(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var product = context.Products.Find(code);
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
