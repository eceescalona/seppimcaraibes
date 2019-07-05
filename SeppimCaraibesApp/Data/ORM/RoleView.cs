namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RoleView")]
    internal partial class RoleView
    {
        [Key]
        [Column(Order = 0)]
        public int RoleId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public string PermissionName { get; set; }
    }
}
