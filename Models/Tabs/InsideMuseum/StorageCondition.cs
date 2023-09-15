using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class StorageCondition
    {
        [Key]
        public int Id { get; set; }
        public string Temperature { get; set; }
        public bool InSafe { get; set; }
        public string Safe { get; set; }
        public string Humidity { get; set; }
        public string Light { get; set; }
        public string Note { get; set; }
    }
}
