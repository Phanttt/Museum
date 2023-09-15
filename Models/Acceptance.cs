using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class Acceptance
    {
        [Key]
        public int Id { get; set; } //номер по книге приема
        public int InventoryN { get; set; }  //инвентарный номер
        public int InsideN { get; set; } //внутренний номер

        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool IsSpecFond { get; set; }
        [Required]
        public bool IsWeapon { get; set; }
        [Required]
        public bool IsDragMetal { get; set; }
        [Required]
        public string Size { get; set; }
        
        public  ICollection<Material>? materials { get; set; }
        
        public  ICollection<State>? states { get; set; }
        
        public  ICollection<Technique>? techniques { get; set; }

        public UnifPassport? UnifPassport { get; set; }
    }
}
