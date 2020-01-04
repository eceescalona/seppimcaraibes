namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal class AccountReceivableCustomerView
    {
        [Key]
        [Column("Customer", Order = 0)]
        [StringLength(50)]
        public string Customer { get; set; }
        public string OrderId { get; set; }
        public double? TotalByOrder { get; set; }
    }
}
