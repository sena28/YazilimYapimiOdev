using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Entity
{
    public class Urun
    {
        public int UrunId { get; set; }

        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }

        [DisplayName("Ürün Miktarı")]
        public int UrunMiktar { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double UrunFiyat { get; set; }

        public string image { get; set; }

        [DisplayName("Satıcı")]
        public int KullaniciId { get; set; }
        public bool UrunOnay { get; set; }
    }
}