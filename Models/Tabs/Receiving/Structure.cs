using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Structure
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
