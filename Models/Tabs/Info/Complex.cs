using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Complex
    {
        [Key]
        public int Id { get; set; }
        public int RefferTo { get; set; }
        public bool IsMain { get; set; }
        public ICollection<UnifPassport> AdditionsItems { get; set; }//?
    }
}
