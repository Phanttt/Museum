using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class MuseumInfo
    {
        [Key]
        public int id { get; set; }
        public bool isOnExhibition { get; set; }
        public Exhibition Exhibition { get; set; }
        public ICollection<Edit> edits { get; set; }
        public DataFile Files { get; set; }
    }
}
