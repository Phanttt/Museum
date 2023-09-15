using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Receiving
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortInfo { get; set; }
        public string FullInfo { get; set; }
        public byte[] Data { get; set; }
        public string Connection { get; set; }
        public ICollection<Link> links { get; set; }
    }
}
