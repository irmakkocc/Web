using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class Diziler
    {
        [Key]
        public int ID { get; set; }
        public string DiziAd { get; set; }
        public string Yonetmen { get; set; }
        public int Puan { get; set; }
        public string DiziAciklama { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}