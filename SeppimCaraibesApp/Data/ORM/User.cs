namespace SeppimCaraibesApp.Data.ORM
{
    using System.Net.Mail;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    internal partial class User
    {
        [Key]
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

        public MailAddress Email { get; set; }

        public PhoneAttribute Phone { get; set; }

        public bool Enable { get; set; }

        [StringLength(250)]
        public string NotEnableCause { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
