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
    public class PtaCategoriesController : Controller
    {
        private PtaK22CNT4Lessson11DbEntities db = new PtaK22CNT4Lessson11DbEntities();

        // GET: PtaCategories
        public ActionResult PtaIndex()
        {
            return View(db.PtaCategories.ToList());
        }

        // GET: PtaCategories/Details/5
        public ActionResult PtaDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaCategory ptaCategory = db.PtaCategories.Find(id);
            if (ptaCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptaCategory);
        }

        // GET: PtaCategories/Create
        public ActionResult PtaCreate()
        {
            return View();
        }

        // POST: PtaCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate([Bind(Include = "PtaID,PtaCateName,PtaStatus")] PtaCategory ptaCategory)
        {
            if (ModelState.IsValid)
            {
                db.PtaCategories.Add(ptaCategory);
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }

            return View(ptaCategory);
        }

        // GET: PtaCategories/Edit/5
        public ActionResult PtaEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaCategory ptaCategory = db.PtaCategories.Find(id);
            if (ptaCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptaCategory);
        }

        // POST: PtaCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit([Bind(Include = "PtaID,PtaCateName,PtaStatus")] PtaCategory ptaCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptaCategory);
        }

        // GET: PtaCategories/Delete/5
        public ActionResult PtaDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaCategory ptaCategory = db.PtaCategories.Find(id);
            if (ptaCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptaCategory);
        }

        // POST: PtaCategories/Delete/5
        [HttpPost, ActionName("PtaDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtaCategory ptaCategory = db.PtaCategories.Find(id);
            db.PtaCategories.Remove(ptaCategory);
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
