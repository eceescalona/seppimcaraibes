namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal partial class TotalSalesCustomerView
    {
        [Key]
        [Column("Customer", Order = 0)]
        [StringLength(50)]
        public string Customer { get; set; }

        public double? Total_Sale { get; set; }
    }
}
