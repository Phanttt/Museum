using Museum.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class ItemDamage
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public User Discoverer { get; set; }
        public Recommendation Recommendation { get; set; }
        public string Note { get; set; }
    }
}
