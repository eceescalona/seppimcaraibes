namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal partial class TotalSalesView
    {
        [Key]
        [Column("Customer", Order = 0)]
        [StringLength(50)]
        public string Customer { get; set; }

        [Key]
        [Column("Provider", Order = 1)]
        [StringLength(50)]
        public string Provider { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public double? Total_Sale { get; set; }

        public decimal? Total_Buy { get; set; }

        public double? Earnings { get; set; }

        public double? Margin { get; set; }
    }
}
