using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Entity
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [DisplayName("Şifre")]
        public string Sifre { get; set; }

        public int Tc { get; set; }
        public int TelNo { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Yetki { get; set; }

    }
}