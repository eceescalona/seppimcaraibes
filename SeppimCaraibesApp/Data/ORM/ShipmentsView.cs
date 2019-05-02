namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipmentsView")]
    public partial class ShipmentsView
    {
        [Key]
        [Column("Order Reference", Order = 0)]
        [StringLength(50)]
        public string Order_Reference { get; set; }

        [Column("Shipping Method")]
        public byte? Shipping_Method { get; set; }

        [Column("Gross Weight")]
        public decimal? Gross_Weight { get; set; }

        [Column("Net Weight")]
        public decimal? Net_Weight { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Packing { get; set; }

        [Column("Place of Departure")]
        [StringLength(250)]
        public string Place_of_Departure { get; set; }
    }
}
