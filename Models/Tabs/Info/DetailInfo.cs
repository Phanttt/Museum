using System.ComponentModel.DataAnnotations;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Museum.Models.Tabs.Info
{
    public class DetailInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Fund Fund { get; set; }
        [Required]
        public ICollection<Collection> collections { get; set; }
        [Required]
        public ICollection<Group> groups { get; set; }
        [Required]
        public bool IsComplex { get; set; }
        [Required]
        public ICollection<KeyWord> KeyWords { get; set; }
        [Required]
        public ICollection<Tag> Tags {get; set; }
        [Required]
        public ICollection<DetLink> Links { get; set; }
        [Required]


        public ICollection<City> cities { get; set; }
        public string FullDescription { get; set; }
        public Decoding Decoding { get; set; }

        public float DSTUSize { get; set; }
        public string Restavration { get; set; }
        public string SimilarItems { get; set; }
        [Required]
        public int Count { get; set; }
        public Gender gender { get; set; }
        public Form Form { get; set; }
        public string color { get; set; }
        public string Thanks { get; set; }
        public Classification Classification { get; set; }

    }
}
