using System.ComponentModel.DataAnnotations;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Museum.Models.Tabs.Info
{
    public class DetailInfo
    {
        [Key]
        public int id { get; set; }
        [Required]
        public Fund Fund { get; set; }
        [Required]
        public ICollection<Collection> collections { get; set; }
        [Required]
        public ICollection<Group> groups { get; set; }
        [Required] 
        public ICollection<KeyWord> keyWords { get; set; }
        [Required]
        public ICollection<Tag> tags {get; set; }
       

    }
}
