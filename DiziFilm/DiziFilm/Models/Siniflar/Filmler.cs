using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class Filmler
    {
        [Key]
        public int ID { get; set; }
        public string FilmAd { get; set; }
        public string Yonetmen { get; set; }
        public int Puan { get; set; }
        public string FilmAciklama { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}