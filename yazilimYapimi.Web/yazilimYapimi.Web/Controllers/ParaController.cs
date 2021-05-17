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
    public class ParaController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Para
        public ActionResult Index()
        {
            return View(db.Paralar.ToList());
        }

        // GET: Para/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Para para = db.Paralar.Find(id);
            if (para == null)
            {
                return HttpNotFound();
            }
            return View(para);
        }

        // GET: Para/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Para/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParaId,KullaniciId,ParaMiktar,ParaOnay")] Para para)
        {
            if (ModelState.IsValid)
            {
                db.Paralar.Add(para);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(para);
        }

        // GET: Para/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Para para = db.Paralar.Find(id);
            if (para == null)
            {
                return HttpNotFound();
            }
            return View(para);
        }

        // POST: Para/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParaId,KullaniciId,ParaMiktar,ParaOnay")] Para para)
        {
            if (ModelState.IsValid)
            {
                db.Entry(para).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(para);
        }

        // GET: Para/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Para para = db.Paralar.Find(id);
            if (para == null)
            {
                return HttpNotFound();
            }
            return View(para);
        }

        // POST: Para/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Para para = db.Paralar.Find(id);
            db.Paralar.Remove(para);
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
