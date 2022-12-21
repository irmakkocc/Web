using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DiziFilm.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<AdminGiris> AdminGirises { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Diziler> Dizilers { get; set; }
        public DbSet<Filmler> Filmlers { get; set; }
        public DbSet<GirisYap> GirisYaps { get; set; }
        public DbSet<SifreUnuttum> SifreUnuttums { get; set; }
        public DbSet<UyeOl> UyeOls { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}