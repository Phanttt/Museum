using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Museum.Models.Tabs.Receiving
{
    public class People
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string info { get; set; }

        [JsonIgnore]
        public ICollection<Receiving>? receivings { get; set; }
    }
}
