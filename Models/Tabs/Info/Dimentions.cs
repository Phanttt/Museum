using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info
{
    public class Dimentions
    {
        [Key]
        public int Id { get; set; }
        public float lenght { get; set; }
        public string LenghtUnit { get; set; }
        public float Width { get; set; }
        public string WidthUnit { get; set; }
        public float Height { get; set; }
        public string HeightUnit { get; set; }
        public float Diameter { get; set; }
        public string DiameterUnit { get; set; }
        public float Thickness { get; set; }
        public string ThicknessUnit { get; set; }
        public float Weight { get; set; }
        public string WeightUnit { get; set; }
        public float WallThickness { get; set; }
        public string WallThicknessUnit { get; set; }
    }
}
