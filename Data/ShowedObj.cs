
using Museum.Models.Tabs.Media;

namespace Museum.Data
{
    public class ShowedObj
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ICollection<Image> images { get; set; }
    }
}
