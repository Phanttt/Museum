using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public Exhibition Exhibition { get; set; }
        public Exposition Exposition { get; set; }
        public string Note { get; set; }
        public bool InsideWork { get; set; }
        public bool isActive { get; set; }
    }
}
