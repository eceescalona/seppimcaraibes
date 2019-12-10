namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipmentsView")]
    internal partial class ShipmentsView
    {
        [Key]
        [Column("Order Reference")]
        [StringLength(50)]
        public string Order_Reference { get; set; }

        [Column("Shipping Method")]
        public EShippingMethod? Shipping_Method { get; set; }

        [Column("Gross Weight")]
        public decimal? Gross_Weight { get; set; }

        [Column("Net Weight")]
        public decimal? Net_Weight { get; set; }

        [Column("Place of Departure")]
        [StringLength(250)]
        public string Place_of_Departure { get; set; }
    }
}
