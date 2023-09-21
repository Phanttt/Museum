using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class BtwMatAcc
    {
        //public BtwMatAcc(int id, int matId, Material Material, int accId, Acceptance Acceptance) {
        //    this.id = id;
        //    this.matId = matId;
        //    this.Material = Material;
        //    this.accId = accId;
        //    this.Acceptance = Acceptance;
        //}

        [Key]
        public int id { get; set; } 
        public Material Material { get; set; }
        public Acceptance Acceptance { get; set; }

    }
}
