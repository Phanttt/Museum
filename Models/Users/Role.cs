using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Users
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }   
    }
}
