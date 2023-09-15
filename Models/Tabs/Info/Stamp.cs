using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Stamp
    {
        [Key]
        public int Id { get; set; }
        public string StampName { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
