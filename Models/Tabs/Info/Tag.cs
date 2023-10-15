using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Tag
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
