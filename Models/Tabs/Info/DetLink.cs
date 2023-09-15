using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class DetLink
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Note { get; set; }
    }
}
