namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrdersView")]
    internal partial class OrdersView
    {
        [Key]
        [Column("Order Code", Order = 0)]
        [StringLength(50)]
        public string Order_Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column("Provider Reference")]
        [StringLength(50)]
        public string Provider_Reference { get; set; }

        [Column("Provider Name")]
        [StringLength(250)]
        public string Provider_Name { get; set; }

        [Column("Provider Phone")]
        [StringLength(50)]
        public string Provider_Phone { get; set; }

        [Column("Customer Reference")]
        [StringLength(50)]
        public string Customer_Reference { get; set; }

        [Column("Customer Name")]
        [StringLength(250)]
        public string Customer_Name { get; set; }

        [Column("Customer Phone")]
        [StringLength(50)]
        public string Customer_Phone { get; set; }

        [Column("Customer Address")]
        public string Customer_Address { get; set; }

        [Column("Payment Option")]
        public EPaymentOption Payment_Option { get; set; }

        [Column("Shipping Method")]
        public EShippingMethod Shipping_Method { get; set; }

        public EDevise Devise { get; set; }

        [StringLength(250)]
        public string Incoterm { get; set; }

        [Key]
        [Column("Product Code", Order = 1)]
        [StringLength(50)]
        public string Product_Code { get; set; }

        [Column("Product Name")]
        [StringLength(250)]
        public string Product_Name { get; set; }

        [Column("Product Qty")]
        public int? Product_Qty { get; set; }

        [Column("Unit Price")]
        public decimal? Unit_Price { get; set; }

        [Column("Product Discount")]
        public decimal? Product_Discount { get; set; }

        [Column("Total Cost")]
        public double? Total_Cost { get; set; }

        [Column("Contract Description", TypeName = "text")]
        public string Contract_Description { get; set; }

        [Column("Documents Required", TypeName = "text")]
        public string Documents_Required { get; set; }
    }
}
