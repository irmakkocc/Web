using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class AdminGiris
    {
        [Key]
        public int ID { get; set; }
        public string Sifre { get; set; }
    }
}