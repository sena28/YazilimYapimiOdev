using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Models
{
    public class UrunModel
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public int UrunMiktar { get; set; }
        public double UrunFiyat { get; set; }
        public string image { get; set; }
        public int KullaniciId { get; set; }
        public bool UrunOnay { get; set; }
    }
}