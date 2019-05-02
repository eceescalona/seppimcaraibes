namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProvidersView")]
    public partial class ProvidersView
    {
        [Key]
        [Column("Provider Code", Order = 0)]
        [StringLength(50)]
        public string Provider_Code { get; set; }

        [Column("Provider Name")]
        [StringLength(250)]
        public string Provider_Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Address { get; set; }

        [Key]
        [Column("Product Code", Order = 1)]
        [StringLength(50)]
        public string Product_Code { get; set; }

        [Column("Product Name")]
        [StringLength(250)]
        public string Product_Name { get; set; }
    }
}
