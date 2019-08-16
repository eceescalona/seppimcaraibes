namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;

    internal partial class Shipment
    {
        [StringLength(50)]
        public string ShipmentId { get; set; }

        public EShippingMethod? ShippingMethod { get; set; }

        public decimal? GrossWeight { get; set; }

        public decimal? NetWeight { get; set; }

        [Required]
        [StringLength(50)]
        public string Packing { get; set; }

        [StringLength(250)]
        public string PlaceDeparture { get; set; }

        [StringLength(250)]
        public string PackingDesciption { get; set; }

        public virtual Order Order { get; set; }
    }
}
