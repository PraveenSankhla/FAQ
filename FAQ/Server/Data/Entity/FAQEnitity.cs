using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAQ_App.Server.Data.Entity
{
    [Table("FAQS")]
    public class FAQEnitity
    {
        [Key]
        [Column("ID"), Required]
        public int Id { get; set; }

        [Column("QUESTION")]
        public string Question { get; set; }

        [Column("ANSWER")]
        public string Answer { get; set; }

        [Column("TOPIC")]
        public string Topic { get; set; }

        [Column("CATEGORY")]
        public string Category { get; set; }
    }
}
