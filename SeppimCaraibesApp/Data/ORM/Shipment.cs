namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    internal partial class Shipment
    {
        [StringLength(50)]
        public string ShipmentId { get; set; }

        public EShippingMethod? ShippingMethod { get; set; }

        public decimal? GrossWeight { get; set; }

        public decimal? NetWeight { get; set; }

        [StringLength(250)]
        public string PlaceDeparture { get; set; }

        [StringLength(250)]
        public string PackingDesciption { get; set; }

        public virtual Order Order { get; set; }
    }
}
