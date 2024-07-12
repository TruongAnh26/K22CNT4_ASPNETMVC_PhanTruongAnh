using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtaOnTap.Models;

namespace PtaOnTap.Controllers
{
    public class PtaTacGiasController : Controller
    {
        private PhanTruongAnh_2210900087Entities db = new PhanTruongAnh_2210900087Entities();

        // GET: PtaTacGias
        public ActionResult PtaIndex()
        {
            return View(db.PtaTacGias.ToList());
        }

        // GET: PtaTacGias/Details/5
        public ActionResult PtaDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaTacGia ptaTacGia = db.PtaTacGias.Find(id);
            if (ptaTacGia == null)
            {
                return HttpNotFound();
            }
            return View(ptaTacGia);
        }

        // GET: PtaTacGias/Create
        public ActionResult PtaCreate()
        {
            return View();
        }

        // POST: PtaTacGias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate([Bind(Include = "Pta_MaTG,Pta_TenTG")] PtaTacGia ptaTacGia)
        {
            if (ModelState.IsValid)
            {
                db.PtaTacGias.Add(ptaTacGia);
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }

            return View(ptaTacGia);
        }

        // GET: PtaTacGias/Edit/5
        public ActionResult PtaEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaTacGia ptaTacGia = db.PtaTacGias.Find(id);
            if (ptaTacGia == null)
            {
                return HttpNotFound();
            }
            return View(ptaTacGia);
        }

        // POST: PtaTacGias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit([Bind(Include = "Pta_MaTG,Pta_TenTG")] PtaTacGia ptaTacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaTacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }
            return View(ptaTacGia);
        }

        // GET: PtaTacGias/Delete/5
        public ActionResult PtaDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaTacGia ptaTacGia = db.PtaTacGias.Find(id);
            if (ptaTacGia == null)
            {
                return HttpNotFound();
            }
            return View(ptaTacGia);
        }

        // POST: PtaTacGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtaTacGia ptaTacGia = db.PtaTacGias.Find(id);
            db.PtaTacGias.Remove(ptaTacGia);
            db.SaveChanges();
            return RedirectToAction("PtaIndex");
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
