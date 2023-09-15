using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Marking
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Inscript> inscripts { get; set; }
        public ICollection<Stamp> stamps { get; set; }
    }
}
