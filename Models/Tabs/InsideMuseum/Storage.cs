using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Place { get; set; }
        public string Note { get; set; }    
    }
}
