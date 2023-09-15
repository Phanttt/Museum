using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Exposition
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
