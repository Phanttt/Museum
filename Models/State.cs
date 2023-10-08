using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Museum.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Acceptance>? acceptances { get; set; }
    }
}
