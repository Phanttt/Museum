using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Edit
    {
        [Key]
        public int id { get; set; }
        public int itemId { get; set; }
        public string description { get; set; }
        [JsonIgnore]
        public ICollection<MuseumInfo> edits { get; set; }
    }
}
