using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        public string Hakkimizda { get; set; }
        public string HakkimizdaAciklama { get; set; }
        public string Film { get; set; }
        public string FilmAciklama { get; set; }
        public string FilmUrl { get; set; }
        public string Dizi { get; set; }
        public string DiziAciklama { get; set; }
        public string DiziUrl { get; set; }
        public DateTime Tarih { get; set; }
    }
}