using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Research
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date {get; set;}
        public string Source { get; set;}
        public string Name { get; set;}
        public string Link { get; set;}
        public string Note { get; set;}
    }
}
