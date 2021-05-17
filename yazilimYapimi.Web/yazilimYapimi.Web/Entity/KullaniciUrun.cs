using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Entity
{
    public class KullaniciUrun
    {
        public int KullaniciUrunId { get; set; }
        public int KullaniciId { get; set; }


        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }

        public int UrunId { get; set; }

        [DisplayName("Ürün Miktarı")]
        public int UrunMiktar { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double UrunFiyat { get; set; }

        public double Fiyat { get; set; }

    }
}