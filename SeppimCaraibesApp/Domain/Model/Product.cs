namespace SeppimCaraibesApp.Domain.Model
{
    using System.Data.Entity;
    using System.Linq;

    internal class Product
    {
        public DbSet<Data.POCO.ProductsOrders> GetProductsOrders(Data.ORM.SeppimCaraibesLocalEntities context)
        {
            var rProduct = new Data.Repository.ProductRepository();
            var products = rProduct.GetProducts(context);
            DbSet<Data.POCO.ProductsOrders> list = null;

            foreach (var product in products)
            {
                var productOrder = new Data.POCO.ProductsOrders
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Qty = 0,
                    Discount = 0,
                    Interests = 0,
                };

                list.Add(productOrder);
            }

            return list;
        }

        public Data.ORM.Product GetProduct(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rProduct = new Data.Repository.ProductRepository();
            return rProduct.GetProduct(context, code);
        }

        public void AddProduct(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Product product)
        {
            var rProduct = new Data.Repository.ProductRepository();
            if (!context.Products.Any(p => p.ProductId == product.ProductId))
            {
                rProduct.AddProduct(context, product);
            }
        }

        public void EditProduct(Data.ORM.SeppimCaraibesLocalEntities context, Data.ORM.Product product)
        {
            var rProduct = new Data.Repository.ProductRepository();
            rProduct.EditProduct(context, product);
        }

        public void DeleteProduct(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rProduct = new Data.Repository.ProductRepository();
            rProduct.DeleteProduct(context, code);
        }
    }
}
