using Museum.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Check
    {
        [Key]
        public int Id { get; set; }
        public CheckType CheckType { get; set; }
        public DateTime Date { get; set; }
        public User Cheker { get; set; }
        public string Result { get; set; }
        public bool IsChecked { get; set; }
        public string Note { get; set; }
    }
}
