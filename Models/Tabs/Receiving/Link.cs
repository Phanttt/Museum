using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Link
    {
        [Key]
        public int Id { get; set; }
        
        string Content { get; set; }
        string Note { get; set; }
    }
}
