namespace SeppimCaraibesApp.Data.ORM
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Origin")]
    internal partial class Origin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Origin()
        {
            Products = new HashSet<Product>();
        }

        public int OriginId { get; set; }

        [StringLength(50)]
        public string OriginName { get; set; }

        [StringLength(10)]
        public string Acronyms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
