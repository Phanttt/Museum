using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
