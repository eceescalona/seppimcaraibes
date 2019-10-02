namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    internal partial class Bank
    {
        public int BankId { get; set; }

        [StringLength(250)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(250)]
        public string AccountName { get; set; }

        public string BankAddress { get; set; }

        [StringLength(50)]
        public string Swift { get; set; }
    }
}
