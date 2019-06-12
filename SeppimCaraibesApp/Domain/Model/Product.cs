namespace SeppimCaraibesApp.Domain.Model
{
    using System.ComponentModel;
    using System.Linq;
    using System.Threading.Tasks;

    internal class Product
    {
        public BindingList<Data.POCO.ProductsOrders> GetProductsOrders(Data.ORM.SeppimCaraibesLocalEntities context)
        {
            var rProduct = new Data.Repository.ProductRepository();
            var products = rProduct.GetProducts(context);
            var productsOrders = new BindingList<Data.POCO.ProductsOrders>();
            foreach (var product in products)
            {
                var productOrder = new Data.POCO.ProductsOrders
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Qty = 0,
                    Discount = 0,
                    Interests = 0,
                    UnitPrice = product.UnitPrice
                };

                productsOrders.Add(productOrder);
            }

            return productsOrders;
        }

        public async Task<Data.ORM.Product> GetProduct(Data.ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var rProduct = new Data.Repository.ProductRepository();
            return await rProduct.GetProduct(context, code);
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
