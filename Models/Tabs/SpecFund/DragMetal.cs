using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.SpecFund
{
    public class DragMetal
    {
        [Key]
        public int Id { get; set; }
        public string DragMetalName { get; set; }
        public int Probe { get; set; }
        public float WeightGramm { get; set; }
        public float WeightKarat { get; set; }
        public byte[] ProbeActScan { get; set; }
    }
}
