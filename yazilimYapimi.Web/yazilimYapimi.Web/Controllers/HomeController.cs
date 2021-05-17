using System;
using System.Collections.Generic;
using yazilimYapimi.Web.Entity;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using yazilimYapimi.Web.Models;

namespace yazilimYapimi.Web.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(_context.urunler.Where(urun => urun.UrunOnay == true).ToList());
        }
        public ActionResult UrunAl()
        {
            return View();
        }
        public ActionResult profil(int id)
        {
          /*  var UrunMiktar = _context.kullaniciUrunler.Where();*/
          /*  ViewBag.urun = UrunMiktar;*/
           ViewBag.Money = _context.Paralar.Where(Para => Para.KullaniciId == id).FirstOrDefault().ParaMiktar;
            return View(_context.kullaniciUrunler.Where(urun => urun.KullaniciId == id).ToList());
        }

        public ActionResult admin()
        {
            return View();
        }

        [HttpPost]
        /*[ValidateAntiForgeryToken]*/
        public ActionResult UrunAlim (/*Urun model,*/int id, int urunMiktar)
        {
            Urun urun = _context.urunler.Where(i => i.UrunId == id).FirstOrDefault();
            KullaniciUrun kUrun = _context.kullaniciUrunler.Find(urun.KullaniciId);
            kUrun.UrunMiktar += urunMiktar;
            urun.UrunMiktar -= urunMiktar;
            _context.Entry(urun).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunAlim(int id)
        {
            var u = _context.urunler.Find(id);
            ViewBag.Urun = u;

            return View();
        }
        [HttpGet]
        
        public ActionResult KayitOl()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult KayitOl(Kullanici kullanici)
        {
            _context.Kullaniciler.Add(kullanici);
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Giris()
        {

           
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Kullanici kullanici)
        {
            var k = _context.Kullaniciler.FirstOrDefault(x => x.KullaniciAdi == kullanici.KullaniciAdi && x.Sifre == kullanici.Sifre);
            
            if (k != null)
            {
                Session["kullaniciID"] = k.Id ;
                Session["yetki"] = k.Yetki ;
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.Hata = "Yanlış Giriş";
                return View();
            }
        }

        public ActionResult Cikis()
        {
            Session.Clear();

            return RedirectToAction("Giris");
        }
    }
}