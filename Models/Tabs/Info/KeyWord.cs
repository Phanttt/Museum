using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class KeyWord
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Meaning { get; set; }
        public string WIKILink { get; set; }
    }
}
