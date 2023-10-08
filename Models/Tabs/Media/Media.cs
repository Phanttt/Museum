using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models.Tabs.Media
{
    public class Media
    {
        [Key]
        public int id { get; set; }
        public ICollection<Image>? Images { get; set; } = new List<Image>();
        [ForeignKey("GeneralInfoId")]
        public GeneralInfo? GeneralInfo { get; set; }
        public ICollection<Audio>? Audios { get; set; } = new List<Audio>();
        public ICollection<Video>? Videos { get; set; } = new List<Video>();
        public ICollection<Document>? Documents { get; set; } = new List<Document>();

    }
}
