using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class DataFile
    {
        [Key]
        public int id { get; set; }
        public byte[]? actToGiftingDeed { get; set; }
        public byte[]? giftingDeed { get; set; }
        public byte[]? intoFondAct { get; set; }
    }
}
