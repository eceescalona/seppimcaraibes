namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    internal partial class Origin
    {
        public int OriginId { get; set; }

        [StringLength(50)]
        public string OriginName { get; set; }

        [StringLength(10)]
        public string Acronyms { get; set; }
    }
}
