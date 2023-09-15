using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Notes
    {
        [Key]
        public int Id { get; set; }
        public string ShortRemarks { get; set; }
        public string Note { get; set; }
        public string NegativeNumber { get; set; }
        public string SafetyRec { get; set; }
        public string ToxicityRec { get; set; }
        public string ExhibitionRec { get; set; }
        public string TransportationRec { get; set; }
        public string TreatmentRec { get; set; }

    }
}
