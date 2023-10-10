using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Museum.Models.Tabs.Media
{
    public class Audio
    {
        [Key]
        public int id { get; set; }
        public byte[] data { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string note{ get; set; }
        public int MediaId { get; set; }
        [JsonIgnore]
        public Media Media { get; set; }
    }
}
