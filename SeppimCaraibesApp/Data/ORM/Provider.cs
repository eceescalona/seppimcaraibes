namespace SeppimCaraibesApp.Data.ORM
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    internal partial class Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provider()
        {
            Products = new HashSet<Product>();
        }

        [StringLength(50)]
        public string ProviderId { get; set; }

        [StringLength(250)]
        public string ProviderName { get; set; }

        [StringLength(50)]
        public string ProviderPhone { get; set; }

        [StringLength(50)]
        public string ProviderEmail { get; set; }

        public string ProviderAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
