namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            ProductsOrders = new HashSet<ProductsOrder>();
        }

        [StringLength(50)]
        public string OrderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? OfferPeriod { get; set; }

        [Column(TypeName = "text")]
        public string ContractDescription { get; set; }

        [Column(TypeName = "text")]
        public string DocRequired { get; set; }

        [Column(TypeName = "text")]
        public string Observations { get; set; }

        public int? Period { get; set; }

        public byte? PeriodState { get; set; }

        [StringLength(250)]
        public string Incoterm { get; set; }

        public byte? Devise { get; set; }

        public byte? PaymentOption { get; set; }

        public double? TotalDiscount { get; set; }

        public decimal? EXW { get; set; }

        public decimal? Freight { get; set; }

        public decimal? FCA { get; set; }

        public decimal? FOB { get; set; }

        public decimal? Insurance { get; set; }

        public decimal? Inspection { get; set; }

        public double? ToltalInterests { get; set; }

        public double? TotalCost { get; set; }

        public byte? CptCfr { get; set; }

        public byte? OrderState { get; set; }

        public byte? OrderProcessState { get; set; }

        public byte? InvoiceState { get; set; }

        public int? BankId { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [StringLength(50)]
        public string ProviderReference { get; set; }

        [StringLength(50)]
        public string InvoiceReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsOrder> ProductsOrders { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
