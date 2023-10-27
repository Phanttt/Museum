using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Exhibition
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string? descriprion { get; set; }
        public byte[]? image { get; set; }
    }
}
