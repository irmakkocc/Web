using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class GirisYap
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
    }
}