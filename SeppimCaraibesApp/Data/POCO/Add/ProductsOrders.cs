namespace SeppimCaraibesApp.Data.POCO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal partial class ProductsOrders
    {
        public decimal? UnitPrice { get; set; }
    }
}
