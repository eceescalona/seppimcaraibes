namespace SeppimCaraibesApp.Data.ORM
{
    using System.Data.Entity;

    internal partial class SeppimCaraibesLocalEntities : DbContext
    {
        public virtual DbSet<ProductsOrdersView> PocoProductsOrders { get; set; }
    }
}
