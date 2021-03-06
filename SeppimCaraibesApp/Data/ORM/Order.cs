namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    internal partial class Order
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

        public EDevise? Devise { get; set; }

        public EPaymentOption? PaymentOption { get; set; }

        public double? TotalDiscount { get; set; }

        public decimal? EXW { get; set; }

        public decimal? Freight { get; set; }

        public decimal? Insurance { get; set; }

        public decimal? Inspection { get; set; }

        public double? ToltalInterests { get; set; }

        public double? TotalCost { get; set; }

        public EIncoterms? IncotermType { get; set; }

        public ECommercialValue? CommercialValue { get; set; }

        public EExpenses? ExpensesType { get; set; }

        public decimal? Expenses { get; set; }

        public EOrderState? OrderState { get; set; }

        public EOrderProcessState? OrderProcessState { get; set; }

        public EInvoiceState? InvoiceState { get; set; }

        public int? BankId { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [StringLength(50)]
        public string ProviderId { get; set; }

        [StringLength(50)]
        public string ProviderReference { get; set; }

        [StringLength(50)]
        public string InvoiceReference { get; set; }

        [Column(TypeName = "text")]
        public string DeliveryTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BigingDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "text")]
        public string PaymentsTerms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsOrder> ProductsOrders { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
