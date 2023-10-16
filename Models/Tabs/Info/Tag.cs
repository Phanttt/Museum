using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Museum.Models.Tabs.Info
{
    public class Tag
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        [JsonIgnore]
        public ICollection<DetailInfo>? detailInfos { get; set; }
    }
}
