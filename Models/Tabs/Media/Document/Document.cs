using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
