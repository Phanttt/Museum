using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Info   
{
    public class Decoding
    {
        [Key]
        public int Id { get; set; }
        public string InscriptLanguage { get; set; }
        public string InscriptOriginal { get; set; }
        public string InscriptTranslation { get; set; }

    }
}
