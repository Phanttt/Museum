using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public EventType Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Longitude { get; set; }
        public string Latitute { get; set; }
    }
}
