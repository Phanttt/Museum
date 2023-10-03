using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models.Tabs.Media
{
    public class GeneralInfo
    {
        [Key]
        public int id { get; set; }

        public string photographer { get; set; }
        public string copyrightHolder { get; set; }
        public ImageRight ImageRight { get; set; }
        [NotMapped]
        public int unifPassportId { get; set; }
    }
}
