namespace SeppimCaraibesApp.Data.ORM
{
    using System.ComponentModel.DataAnnotations;

    internal partial class Origin
    {
        public int OriginId { get; set; }

        [StringLength(50)]
        public string OriginName { get; set; }

        [StringLength(10)]
        public string Acronyms { get; set; }
    }
}
