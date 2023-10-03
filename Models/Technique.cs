using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class Technique
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Acceptance>? acceptances { get; set; }
    }
}
