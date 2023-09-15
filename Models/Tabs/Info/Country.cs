using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }
    }
}
