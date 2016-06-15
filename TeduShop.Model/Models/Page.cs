using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }

        public string Content { get; set; }
    }
}