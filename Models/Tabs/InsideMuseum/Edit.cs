using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Edit
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
    }
}
