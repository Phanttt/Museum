using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Link> links { get; set; }
        public string PassportDetail { get; set; }
        public string Identif { get; set; }
        public byte[] Image { get; set; }
        public string Сaption { get; set; }
        public byte[] TransferAgreement { get; set; }
        public byte[] TransferAct { get; set; }
        public Category Category { get; set; }
        string Note { get; set; }
    }
}
