namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    internal partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductsOrders = new HashSet<ProductsOrder>();
            ProductsOrigins = new HashSet<ProductsOrigin>();
            Providers = new HashSet<Provider>();
        }

        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        [StringLength(50)]
        public string CustomsCode { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? QtyUnits { get; set; }

        public decimal? QtyPrice { get; set; }

        public decimal? SalePrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsOrder> ProductsOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsOrigin> ProductsOrigins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Provider> Providers { get; set; }
    }
}
