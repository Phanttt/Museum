using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class Media
    {
        [Key]
        public int id { get; set; }
        public ICollection<Image>? Images { get; set; }
        public GeneralInfo GeneralInfo { get; set; }
        public ICollection<Audio>? Audios { get; set; }
        public ICollection<Video>? Videos { get; set; }
        public ICollection<Document>? Documents { get; set; }

    }
}
