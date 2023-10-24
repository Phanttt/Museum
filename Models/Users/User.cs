using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Users
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Role Role { get; set; }
    }
}
