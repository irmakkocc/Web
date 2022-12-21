using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KAdi { get; set; }
        public string YrmBaslik { get; set; }
        public int YrmPuan { get; set; }
        public string Yorum { get; set; }
        public Filmler Filmler { get; set; }
        public Diziler Diziler { get; set; }
    }
}