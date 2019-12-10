namespace SeppimCaraibesApp.Data.POCO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    internal class OrderReportView
    {
        public string SeppimName { get => "Seppim Caribes SA"; }

        public string SeppimAddress { get => "Ave. Samuel Lewis, Edificio Comosa, 1er piso, Ciudad de Panamá, Panamá"; }


        #region Invoice
        [StringLength(50)]
        public string InvoiceReference { get; set; }

        [StringLength(250)]
        public string BankName { get; set; }

        public string BankAddress { get; set; }

        public string Swift { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(250)]
        public string AccountName { get; set; }

        public decimal? Insurance { get; set; }

        public decimal? Inspection { get; set; }

        public double? ToltalInterests { get; set; }

        public double? TotalDiscount { get; set; }
        #endregion


        #region Order
        public string DocRequired { get; set; }
        #endregion


        #region Quote
        public int? OfferPeriod { get; set; }

        public decimal? GrossWeight { get; set; }

        public decimal? NetWeight { get; set; }

        public string PackingDescription { get; set; }

        [StringLength(250)]
        public string PlaceOfDeparture { get; set; }

        public string Observations { get; set; }
        #endregion


        [StringLength(50)]
        public string OrderCode { get; set; }

        public DateTime? Date { get; set; }

        public string DeliveryTime { get; set; }

        public DateTime? BigingDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string ProviderReference { get; set; }

        [StringLength(250)]
        public string ProviderName { get; set; }

        [StringLength(50)]
        public string ProviderPhone { get; set; }

        public string ProviderAddress { get; set; }

        [StringLength(50)]
        public string CustomerReference { get; set; }

        [StringLength(250)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

        public string PaymentOption { get; set; }

        public string ShippingMethod { get; set; }

        public EDevise? Devise { get; set; }

        public EIncoterms? IncotermsType { get; set; }

        public IList<ProductsOrdersReports> Products { get; set; }

        public decimal? EXW { get; set; }

        public decimal? Freight { get; set; }

        public double? TotalCost { get; set; }

        public string ContractDescription { get; set; }

        public int? Period { get; set; }

        public EExpenses? ExpensesType { get; set; }

        public decimal? Expenses { get; set; }

        public string PaymentsTerms { get; set; }
    }
}
