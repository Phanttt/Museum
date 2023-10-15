using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Museum.Models.Tabs.Media
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        public byte[]? data { get; set; }
        public string? link { get; set; }
        [Required]
        public string description { get; set; }
        public bool isMain { get; set; }
        [NotMapped]
        public int unifPassportId { get; set; }

        public int? MediaId { get; set; }
        [JsonIgnore]
        public Media? Media { get; set; }
    }
}
