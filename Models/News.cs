using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{
    public class News
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength]
        public string description { get; set; }
        public byte[]? image { get; set; }
        public DateTime? date { get; set; }
    }
}
