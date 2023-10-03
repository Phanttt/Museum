using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class ImageRight
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
