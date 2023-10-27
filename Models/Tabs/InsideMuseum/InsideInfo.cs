using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class InsideInfo
    {
        [Key]
        public int id { get; set; }
        public Exhibition? exhibition { get; set; }
        public ICollection<Edit>? edits { get; set; }
        public DataFile? Files { get; set; }
    }
}
