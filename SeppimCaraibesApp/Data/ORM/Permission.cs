namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Permission")]
    internal partial class Permission
    {
        public int PermissionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Group { get; set; }
    }
}
