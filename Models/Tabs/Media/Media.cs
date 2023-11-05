using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models.Tabs.Media
{
    public class Media
    {
        [Key]
        public int id { get; set; }
        public ICollection<Image>? Images { get; set; } = new List<Image>();
  
        public GeneralInfo? GeneralInfo { get; set; }

    }
}
