using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class MuseumInfo
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Check> Checks { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public StorageCondition StorageCondition { get; set; }
        public ICollection<ItemDamage> ItemDamage { get; set; }
        public Deleting Deleting { get; set; }
        public Location Location { get; set; }

        public Edit Edit { get; set; } 
    }
}
