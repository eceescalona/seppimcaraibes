﻿namespace SeppimCaraibesApp.Data.POCO
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal class ProductsOrdersReports
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        public int? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(50)]
        public string CustomsCode { get; set; }

        public virtual string Origin { get; set; }

        public decimal? SalePrice { get; set; }
    }
}
