using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Museum.Models.Tabs.Info
{
    public class Classification
    {
        [Key]
        public int Id { get; set; }
        public string PartItem { get; set; }
        public string ItemsGroup { get; set; }
        public string ClassifName { set; get; }
    }
}
