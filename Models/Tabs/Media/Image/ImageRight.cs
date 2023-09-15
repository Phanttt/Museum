using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class ImageRight
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
