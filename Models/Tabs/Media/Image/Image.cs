using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string Link{ get; set; }
        public string Description { get; set; }
        public bool IsMain { get; set; }
        public string Photographer { get; set; }
        public string CopyrightHolder { get; set; }
        public ImageRight ImageRight { get; set; }

    }
}
