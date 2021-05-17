using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Entity
{
    public class DataContext:DbContext
    {

        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Urun> urunler { get; set; }
        public DbSet<KullaniciUrun> kullaniciUrunler { get; set; }
        public DbSet<Para> Paralar { get; set; }
        public DbSet<Kullanici> Kullaniciler { get; set; }

    }
}