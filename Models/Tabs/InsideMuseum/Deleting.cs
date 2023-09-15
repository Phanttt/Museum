using Museum.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Deleting
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateOnly { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public byte[] DeletingAct { get; set; }
    }
}
