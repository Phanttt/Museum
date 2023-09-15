using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class Receiving
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public ICollection<Owner> Owners { get; set; }
        [Required]
        public Provider Provider { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public ReceiveWay ReceiveWay { get; set; }
        [Required]
        public Purpose Purpose { get; set; }
        [Required]
        public byte[] ReceiptAct { get; set; }
        [Required]
        public byte[] ReceiptAgreement { get; set; }


        public decimal Price { get; set; }
        public byte[] PriceAct { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public ICollection<Structure> Sructures { get; set; }
        public Producer Producers { get; set; }
        public ICollection<People>  peoples{ get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
