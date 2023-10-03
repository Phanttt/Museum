﻿using System.ComponentModel.DataAnnotations;

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
        public DateTime date { get; set; }
        [Required]
        public ReceiveWay ReceiveWay { get; set; }
        [Required]
        public Purpose Purpose { get; set; }
        [Required]
        public byte[] receiptAct { get; set; }
        [Required]
        public byte[] receiptAgreement { get; set; }


        public decimal price { get; set; }
        public Currency Currency { get; set; }
        public byte[] priceAct { get; set; }
        public DateTime periodFrom { get; set; }
        public DateTime periodTo { get; set; }
        public ICollection<Structure> structures { get; set; }
        public Producer Producer { get; set; }
        public ICollection<People>  peoples{ get; set; }

        public ICollection<Event> events { get; set; }
        public string DescriptionFP { get; set; }
    }
}
