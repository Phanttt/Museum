using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Exhibition
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
