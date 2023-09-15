using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class CheckType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
