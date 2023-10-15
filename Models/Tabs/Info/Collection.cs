using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Collection
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
