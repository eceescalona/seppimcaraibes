namespace SeppimCaraibesApp.Data.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    internal partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nick { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public bool Enable { get; set; }

        [StringLength(250)]
        public string NotEnableCause { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
