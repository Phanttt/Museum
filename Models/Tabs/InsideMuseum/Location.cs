using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.InsideMuseum
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public bool IsOnExhibition { get; set; }
        public bool IsOnExposition { get; set; }
        public bool IsOnStorage { get; set; }
        public Storage Storage { get; set; }
        public string Closet { get; set; }
        public string Shelf { get; set; }
        public string Box { get; set; }
        public string Place { get; set; }
    }
}
