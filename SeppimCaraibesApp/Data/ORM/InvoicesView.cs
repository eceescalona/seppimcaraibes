namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoicesView")]
    internal partial class InvoicesView
    {
        [Key]
        [Column("Order Code")]
        [StringLength(50)]
        public string Order_Code { get; set; }

        [Column("Invoice Reference")]
        [StringLength(50)]
        public string Invoice_Reference { get; set; }

        [Column("Contract Description", TypeName = "text")]
        public string Contract_Description { get; set; }

        [Column("Customer Reference")]
        [StringLength(50)]
        public string Customer_Reference { get; set; }

        [Column("Customer Name")]
        [StringLength(250)]
        public string Customer_Name { get; set; }

        [Column("Product Code")]
        [StringLength(50)]
        public string Product_Code { get; set; }

        [Column("Product Name")]
        [StringLength(250)]
        public string Product_Name { get; set; }

        [Column("Product Qty")]
        public int? Product_Qty { get; set; }

        [Column("Product Interests")]
        public decimal? Product_Interests { get; set; }

        [Column("Product Discount")]
        public decimal? Product_Discount { get; set; }

        [Column("Payment Option")]
        public EPaymentOption? Payment_Option { get; set; }

        public int? Period { get; set; }

        [Column("Bank Name")]
        [StringLength(250)]
        public string Bank_Name { get; set; }

        [Column("Account Number")]
        [StringLength(50)]
        public string Account_Number { get; set; }

        [Column("Account Name")]
        [StringLength(250)]
        public string Account_Name { get; set; }

        [Column("Total Discount")]
        public double? Total_Discount { get; set; }

        public decimal? Freight { get; set; }

        public decimal? Insurance { get; set; }

        public decimal? Inspection { get; set; }

        [Column("Total Interests")]
        public double? Total_Interests { get; set; }

        [Column("Incoterm Type")]
        public EIncoterms? Incoterm_Type { get; set; }

        [Column("Total Cost")]
        public double? Total_Cost { get; set; }
    }
}
