namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductsOrder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string OrderId { get; set; }

        public int? Qty { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Interests { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
