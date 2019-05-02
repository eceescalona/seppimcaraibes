namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsView")]
    public partial class ProductsView
    {
        [Key]
        [Column("Product Code", Order = 0)]
        [StringLength(50)]
        public string Product_Code { get; set; }

        [Column("Product Name")]
        [StringLength(250)]
        public string Product_Name { get; set; }

        [Column("Product Description")]
        public string Product_Description { get; set; }

        [Column("Customs Code")]
        [StringLength(50)]
        public string Customs_Code { get; set; }

        [Column("Unit Price")]
        public decimal? Unit_Price { get; set; }

        [Column("Qty Units")]
        public int? Qty_Units { get; set; }

        [Column("Qty Price")]
        public decimal? Qty_Price { get; set; }

        [Column("Sale Price")]
        public decimal? Sale_Price { get; set; }

        [StringLength(50)]
        public string Origin { get; set; }

        [StringLength(10)]
        public string Acronyms { get; set; }

        [Key]
        [Column("Provider Code", Order = 1)]
        [StringLength(50)]
        public string Provider_Code { get; set; }

        [Column("Provider Name")]
        [StringLength(250)]
        public string Provider_Name { get; set; }
    }
}
