using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class Media
    {
        [Key]
        public int Id { get; set; }
        ICollection<Image> Images { get; set; }
        ICollection<Audio> Audios { get; set; }
        ICollection<Video> Videos { get; set; }
        ICollection<Document> Documents { get; set; }

    }
}
