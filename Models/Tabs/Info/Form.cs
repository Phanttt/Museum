using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
