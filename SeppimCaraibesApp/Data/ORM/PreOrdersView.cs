namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PreOrdersView")]
    internal partial class PreOrdersView
    {
        [Key]
        [Column("Order Code", Order = 0)]
        [StringLength(50)]
        public string Order_Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column("Customer Reference")]
        [StringLength(50)]
        public string Customer_Reference { get; set; }

        [Column("Customer Code", Order = 1)]
        [StringLength(50)]
        public string Customer_Code { get; set; }

        [Column("Customer Name")]
        [StringLength(250)]
        public string Customer_Name { get; set; }

        [Column("Product Code", Order = 2)]
        [StringLength(50)]
        public string Product_Code { get; set; }

        [Column("Product Name")]
        [StringLength(250)]
        public string Product_Name { get; set; }

        [Column("Product Qty")]
        public int? Product_Qty { get; set; }
    }
}
