namespace SeppimCaraibesApp.Data.POCO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal partial class ProductsOrders
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        public int? Qty { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Interests { get; set; }
    }
}
