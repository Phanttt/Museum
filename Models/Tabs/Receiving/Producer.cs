using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Producer
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
