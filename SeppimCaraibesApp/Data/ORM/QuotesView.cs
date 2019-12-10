namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuotesView")]
    internal partial class QuotesView
    {
        [Key]
        [Column("Order Code")]
        [StringLength(50)]
        public string Order_Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column("Offer Period")]
        public int? Offer_Period { get; set; }

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
        public EPaymentOption? Payment_Option { get; set; }

        [Column("Shipping Method")]
        public EShippingMethod? Shipping_Method { get; set; }

        public EDevise? Devise { get; set; }

        [Column("Product Code")]
        [StringLength(50)]
        public string Product_Code { get; set; }

        [Column("Product Name")]
        [StringLength(250)]
        public string Product_Name { get; set; }

        [Column("Product Qty")]
        public int? Product_Qty { get; set; }

        [Column("Unit Price")]
        public decimal? Unit_Price { get; set; }

        public decimal? Discount { get; set; }

        public decimal? EXW { get; set; }

        public decimal? Freight { get; set; }

        [Column("Incoterm Type")]
        public EIncoterms? Incoterm_Type { get; set; }

        [Column("Total Cost")]
        public double? Total_Cost { get; set; }

        [Column("Gross Weight")]
        public decimal? Gross_Weight { get; set; }

        [Column("Net Weight")]
        public decimal? Net_Weight { get; set; }

        [Column("Place of Departure")]
        [StringLength(250)]
        public string Place_of_Departure { get; set; }
    }
}
