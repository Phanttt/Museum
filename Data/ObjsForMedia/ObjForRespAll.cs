using Microsoft.Data.SqlClient;
using Museum.Models.Tabs.Media;

namespace Museum.Data.ObjsForMediaRequests
{
    public class ObjForRespAll
    {
        public int id { get; set; }
        public string name { get; set; }
        public Image images { get; set; }
        public string description { get; set; } 
    }
}
