namespace SeppimCaraibesApp.Domain.Model
{
    using System.Linq;

    internal class Product
    {
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
