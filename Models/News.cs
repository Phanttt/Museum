using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class News
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public byte[]? image { get; set; }
        public DateTime? date { get; set; }
    }
}
