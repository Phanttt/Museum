using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Museum.Models.Tabs.Info
{
    public class DetailInfo
    {
        [Key]
        public int id { get; set; }
        public Fund? Fund { get; set; }
        public ICollection<Collection>? collections { get; set; }
        public ICollection<Group>? groups { get; set; }
        public ICollection<KeyWord>? keyWords { get; set; }
        public ICollection<Tag>? tags {get; set; }
    }
}
