using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Museum.Models.Tabs.Receiving
{
    public class Event
    {
        [Key]
        public int id { get; set; }
        public EventType Type { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public string longitude { get; set; }
        public string latitute { get; set; }

        [JsonIgnore]
        public ICollection<Receiving>? receivings { get; set; }
    }
}
