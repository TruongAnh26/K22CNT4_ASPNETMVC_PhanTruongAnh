using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtaK22CNT4Lesson11Db.Models;

namespace PtaK22CNT4Lesson11Db.Controllers
{
    public class PtaProductsController : Controller
    {
        private PtaK22CNT4Lessson11DbEntities db = new PtaK22CNT4Lessson11DbEntities();

        // GET: PtaProducts
        public ActionResult PtaIndex()
        {
            var ptaProducts = db.PtaProducts.Include(p => p.PtaCategory);
            return View(ptaProducts.ToList());
        }

        // GET: PtaProducts/Details/5
        public ActionResult PtaDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaProduct ptaProduct = db.PtaProducts.Find(id);
            if (ptaProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptaProduct);
        }

        // GET: PtaProducts/Create
        public ActionResult PtaCreate()
        {
            ViewBag.PtaCateId = new SelectList(db.PtaCategories, "PtaID", "PtaCateName");
            return View();
        }

        // POST: PtaProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate([Bind(Include = "PtaID2210900087,PtaProName,PtaQty,PtaPrice,PtaCateId,PtaActive")] PtaProduct ptaProduct)
        {
            if (ModelState.IsValid)
            {
                db.PtaProducts.Add(ptaProduct);
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }

            ViewBag.PtaCateId = new SelectList(db.PtaCategories, "PtaID", "PtaCateName", ptaProduct.PtaCateId);
            return View(ptaProduct);
        }

        // GET: PtaProducts/Edit/5
        public ActionResult PtaEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaProduct ptaProduct = db.PtaProducts.Find(id);
            if (ptaProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.PtaCateId = new SelectList(db.PtaCategories, "PtaID", "PtaCateName", ptaProduct.PtaCateId);
            return View(ptaProduct);
        }

        // POST: PtaProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit([Bind(Include = "PtaID2210900087,PtaProName,PtaQty,PtaPrice,PtaCateId,PtaActive")] PtaProduct ptaProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }
            ViewBag.PtaCateId = new SelectList(db.PtaCategories, "PtaID", "PtaCateName", ptaProduct.PtaCateId);
            return View(ptaProduct);
        }

        // GET: PtaProducts/Delete/5
        public ActionResult PtaDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaProduct ptaProduct = db.PtaProducts.Find(id);
            if (ptaProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptaProduct);
        }

        // POST: PtaProducts/Delete/5
        [HttpPost, ActionName("PtaDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult PtaDeleteConfirmed(string id)
        {
            PtaProduct ptaProduct = db.PtaProducts.Find(id);
            db.PtaProducts.Remove(ptaProduct);
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
