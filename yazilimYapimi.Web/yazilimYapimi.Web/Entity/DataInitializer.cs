using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace yazilimYapimi.Web.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var urunler = new List<Urun>()
            {
                new Urun() { UrunId = 1, UrunMiktar = 40, UrunFiyat=50, KullaniciId=1, UrunOnay=true, image="1.jpg", UrunAdi="Çilek" },
                new Urun() { UrunId = 2, UrunMiktar = 70, UrunFiyat=60, KullaniciId=2, image="2.jpg", UrunAdi="Fındık" },
                new Urun() { UrunId = 3, UrunMiktar = 50, UrunFiyat=62, KullaniciId=3,  UrunOnay=true, image="3.jpg",UrunAdi="Patates" },
                new Urun() { UrunId = 4, UrunMiktar = 100, UrunFiyat=26, KullaniciId=4, image="4.jpg", UrunAdi="Mandalina" },
                new Urun() { UrunId = 5, UrunMiktar = 80, UrunFiyat=34, KullaniciId=5, image="5.jpg", UrunAdi="Ceviz" },
                new Urun() { UrunId = 6, UrunMiktar = 34, UrunFiyat=27, KullaniciId=6, UrunOnay=true, image="6.jpg", UrunAdi="Ananas" },
                new Urun() { UrunId = 7, UrunMiktar = 34, UrunFiyat=27, KullaniciId=7, UrunOnay=false, image="6.jpg", UrunAdi="Ananas" }
            };

            foreach(var urun in urunler)
            {
                context.urunler.Add(urun);
            }
           

            var kullaniciUrunler = new List<KullaniciUrun>()
            {
                new KullaniciUrun()  { UrunId = 1, UrunMiktar = 40, UrunFiyat=50, KullaniciId=1,UrunAdi="Çilek"},
                new KullaniciUrun()  { UrunId = 2, UrunMiktar = 70, UrunFiyat=60, KullaniciId=2, UrunAdi="Fındık" },
                new KullaniciUrun()  { UrunId = 3, UrunMiktar = 50, UrunFiyat=62, KullaniciId=3,UrunAdi="Patates" },
                new KullaniciUrun()  { UrunId = 4, UrunMiktar = 100, UrunFiyat=26, KullaniciId=1, UrunAdi="Mandalina" },
                new KullaniciUrun()  { UrunId = 5, UrunMiktar = 80, UrunFiyat=34, KullaniciId=2, UrunAdi="Ceviz" },
                new KullaniciUrun()  { UrunId = 6, UrunMiktar = 34, UrunFiyat=27, KullaniciId=3, UrunAdi="Ananas" },
                new KullaniciUrun()  { UrunId = 7, UrunMiktar = 34, UrunFiyat=27, KullaniciId=1, UrunAdi="Ananas" }

            };


            foreach(var kullaniciUrun in kullaniciUrunler)
            {
                context.kullaniciUrunler.Add(kullaniciUrun);
            }
           


            var paralar = new List<Para>()
            {
                new Para() {KullaniciId=4,ParaId=1, ParaMiktar=20, ParaOnay=true},
                new Para() {KullaniciId=2,ParaId=2, ParaMiktar=100, ParaOnay=true},
                new Para() {KullaniciId=6,ParaId=3, ParaMiktar=50, ParaOnay=true}

            };


            foreach(var para in paralar)
            {
                context.Paralar.Add(para);
            }
        


            var kullanicilar = new List<Kullanici>()
            {
                new Kullanici() {KullaniciAdi="snc", Sifre= "123", Yetki="satici"},
                new Kullanici() {KullaniciAdi="krai", Sifre= "123", Yetki="satici"},
                new Kullanici() {KullaniciAdi="cri", Sifre= "123", Yetki="satici"},
                new Kullanici() {KullaniciAdi="SyKan", Sifre= "123", Yetki="musteri"},
                new Kullanici() {KullaniciAdi="wiyuvi", Sifre= "123", Yetki="musteri"},
                new Kullanici() {KullaniciAdi="bebis", Sifre= "123", Yetki="musteri"},
                new Kullanici() {KullaniciAdi="admin", Sifre= "123", Yetki="admin"}

            };


            foreach (var kullanici in kullanicilar)
            {
                context.Kullaniciler.Add(kullanici);
            }


            context.SaveChanges();

            base.Seed(context);
        }
    }
}