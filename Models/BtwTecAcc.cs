using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class BtwTecAcc
    {
        [Key]
        public int id { get; set; }
        public Technique Technique { get; set; }
        public Acceptance? Acceptance { get; set; }
    }
}
