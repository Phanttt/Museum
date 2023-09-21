using Museum.Models;
using System.ComponentModel.DataAnnotations;

namespace Museum.Data
{
    public class AcceptRequest
    {
        public int id { get; set; } 
        public int inventoryN { get; set; }  
        public int insideN { get; set; } 
        public int specFondNum { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
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
        public List<Material> materials { get; set; }
        public List<State> states { get; set; }
        public List<Technique> techniques { get; set; }
    }
}
