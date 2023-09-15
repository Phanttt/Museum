using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Country country { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }
    }
}
