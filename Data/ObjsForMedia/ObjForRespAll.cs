using Microsoft.Data.SqlClient;
using Museum.Models.Tabs.Media;

namespace Museum.Data.ObjsForMediaRequests
{
    public class ObjForRespAll
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Image> images { get; set; }
    }
}
