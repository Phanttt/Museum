using Museum.Models.Tabs.Info;
using Museum.Models.Tabs.InsideMuseum;
using Museum.Models.Tabs.Media;
using Museum.Models.Tabs.Receiving;
using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class UnifPassport
    {
        [Key]
        public int Id { get; set; }
        public DetailInfo? DetailInfo { get; set; }
        public MuseumInfo? MuseumInfo { get; set; }
        public Media? Media { get; set; }
        public Receiving? Receiving { get; set; }
    }
}
