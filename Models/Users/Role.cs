using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Users
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }   
    }
}
