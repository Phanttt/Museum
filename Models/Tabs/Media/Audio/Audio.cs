using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class Audio
    {
        [Key]
        public int id { get; set; }
        public byte[] data { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string note{ get; set; }

        ICollection<Media> Medias { get; set; }
    }
}
