namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal partial class TotalSalesProviderView
    {
        [Key]
        [Column("Provider", Order = 0)]
        [StringLength(50)]
        public string Provider { get; set; }

        public double? Total_Sale { get; set; }
    }
}
