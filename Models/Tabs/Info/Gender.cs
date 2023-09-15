using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
