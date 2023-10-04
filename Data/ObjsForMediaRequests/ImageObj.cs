using Museum.Models.Tabs.Media;

namespace Museum.Data.ObjsForMediaRequests
{
    public class ImageObj
    {
        public Image img { get; set; }
        public List<byte> imageBytes { get; set; }
    }
}
