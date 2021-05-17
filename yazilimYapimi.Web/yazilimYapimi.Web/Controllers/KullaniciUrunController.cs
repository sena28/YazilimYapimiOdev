using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using yazilimYapimi.Web.Entity;

namespace yazilimYapimi.Web.Controllers
{
    public class KullaniciUrunController : Controller
    {
        private DataContext db = new DataContext();

        // GET: KullaniciUrun
        public ActionResult Index()
        {
            return View(db.kullaniciUrunler.ToList());
        }

        // GET: KullaniciUrun/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KullaniciUrun/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KullaniciUrunId,KullaniciId,UrunId,UrunMiktar,UrunFiyat,Fiyat")] KullaniciUrun kullaniciUrun)
        {
            if (ModelState.IsValid)
            {
                db.kullaniciUrunler.Add(kullaniciUrun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kullaniciUrun);
        }

        // GET: KullaniciUrun/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KullaniciUrun kullaniciUrun = db.kullaniciUrunler.Find(id);
            if (kullaniciUrun == null)
            {
                return HttpNotFound();
            }
            return View(kullaniciUrun);
        }

        // POST: KullaniciUrun/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KullaniciUrunId,KullaniciId,UrunId,UrunMiktar,UrunFiyat,Fiyat")] KullaniciUrun kullaniciUrun)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kullaniciUrun).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kullaniciUrun);
        }

        // GET: KullaniciUrun/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KullaniciUrun kullaniciUrun = db.kullaniciUrunler.Find(id);
            if (kullaniciUrun == null)
            {
                return HttpNotFound();
            }
            return View(kullaniciUrun);
        }

        // POST: KullaniciUrun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KullaniciUrun kullaniciUrun = db.kullaniciUrunler.Find(id);
            db.kullaniciUrunler.Remove(kullaniciUrun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
