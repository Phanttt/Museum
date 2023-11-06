using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{
    public class Acceptance
    {
        [Key]
        public int id { get; set; }  //номер по книге приема
        public int inventoryN { get; set; }  //инвентарный номер
        public int insideN { get; set; } //внутренний номер
        public int specFondNum { get; set; } 

        [Required]
        public string name { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [MaxLength(255)]
        public string shortDescription { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public bool isSpecFond { get; set; }
        [Required]
        public bool isWeapon { get; set; }
        [Required]
        public bool isDragMetal { get; set; }
        [Required]
        public string size { get; set; }
        
        public ICollection<Material> materials { get; set; }
        
        public ICollection<State> states { get; set; }
       
        public ICollection<Technique> techniques { get; set; }

        public UnifPassport? unifPassport { get; set; }
    }
}
