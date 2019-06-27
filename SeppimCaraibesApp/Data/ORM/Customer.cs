namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;

    internal partial class Customer
    {
        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(250)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        public string CustomerAddress { get; set; }
    }
}
