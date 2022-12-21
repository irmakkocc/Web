using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiziFilm.Models.Siniflar
{
    public class UyeOl
    {
        [Key]
        public string Mail { get; set; }
        public string KAdi { get; set; }
        public string KSifre { get; set; }
        public string KSifreTekrar { get; set; }
    }
}