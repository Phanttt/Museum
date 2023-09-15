using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class TimeLimit
    {
        [Key]
        public int Id { get; set; }
        public DateTime CopyrightPeriod { get; set; }
        public DateTime CloseTo { get; set; }
        public DateTime PublishFrom { get; set; }
        public DateTime ShelfLifeEnd { get; set; }
        public string Note { get; set; }
    }
}
