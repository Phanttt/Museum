using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Fund
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public string Link { get; set; }
        public string Location { get; set; }
        public string Signature { get; set; }
    }
}
