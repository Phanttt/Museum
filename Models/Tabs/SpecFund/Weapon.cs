using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.SpecFund
{
    public class Weapon
    {
        [Key]
        public int Id { get; set; }
        public bool IsMuseumWeapon { get; set; }
        public bool IsPartOfWeapon { get; set; }
        public string PartOfWeaponName { get; set; }
        public bool IsAmmo { get; set; }
        public string AmmoName { get; set; }
        public bool MMG { get; set; }
        public byte[] PassportScan { get; set; }
        public byte[] ExpertizionScan { get; set; }

    }
}
