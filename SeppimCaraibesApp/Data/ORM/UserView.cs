namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserView")]
    internal partial class UserView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string User { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Enable { get; set; }

        [StringLength(50)]
        public string Role { get; set; }
    }
}
