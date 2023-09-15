using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.SpecFund
{
    public class SpecFund
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }
        public DragMetal DragMetal { get; set; }
        public Weapon Weapon { get; set; }
    }
}
