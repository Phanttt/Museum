﻿using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Tabs.Media
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public byte[] data { get; set; }
        public string link{ get; set; }
        public string description { get; set; }
        public bool isMain { get; set; }

        ICollection<Media> Medias { get; set; }
    }
}
