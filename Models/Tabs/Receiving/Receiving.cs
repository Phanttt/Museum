using Museum.Models.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models.Tabs.Receiving
{
    public class Receiving
    {
        [Key]
        public int id { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public Owner Owner { get; set; }
        [Required]
        public Provider Provider { get; set; }
        public User Recipient { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public ReceiveWay ReceiveWay { get; set; }
        [Required]
        public Purpose Purpose { get; set; }
        public byte[]? receiptAct { get; set; }
        public byte[]? receiptAgreement { get; set; }


        public int price { get; set; }
        public Currency? Currency { get; set; }
        public byte[]? priceAct { get; set; }
        public string periodFrom { get; set; }
        public string periodTo { get; set; }
        public ICollection<Structure> structures { get; set; }
        public ICollection<Event>? events { get; set; }
        public ICollection<People> peoples { get; set; }

        [Required]
        public Producer Producer { get; set; }
        public string? descriptionFP { get; set; }
    }
}
