using Museum.Models.Tabs.Media;
using Museum.Models.Tabs.Receiving;

namespace Museum.Data.ObjsForReceiving
{
    public class ReceiveObj
    {
        public Receiving receiving { get; set; }
        public List<byte>? receiptAct { get; set; }
        public List<byte>? receiptAgreement { get; set; }
        public List<byte>? priceAct { get; set; }
        public int unifId { get; set; }
    }
}
