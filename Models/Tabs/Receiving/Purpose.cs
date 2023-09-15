using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Purpose
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
