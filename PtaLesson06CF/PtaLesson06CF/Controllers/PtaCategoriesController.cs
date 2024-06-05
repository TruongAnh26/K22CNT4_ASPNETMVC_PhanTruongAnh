using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtaLesson06CF.Models;

namespace PtaLesson06CF.Controllers
{
    public class PtaCategoriesController : Controller
    {
        private PtaBookStore db = new PtaBookStore();

        // GET: PtaCategories
        public ActionResult Index()
        {
            return View(db.PtaCategories.ToList());
        }

        // GET: PtaCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaCategories ptaCategories = db.PtaCategories.Find(id);
            if (ptaCategories == null)
            {
                return HttpNotFound();
            }
            return View(ptaCategories);
        }

        // GET: PtaCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtaCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtaId,PtaCategoryName")] PtaCategories ptaCategories)
        {
            if (ModelState.IsValid)
            {
                db.PtaCategories.Add(ptaCategories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptaCategories);
        }

        // GET: PtaCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaCategories ptaCategories = db.PtaCategories.Find(id);
            if (ptaCategories == null)
            {
                return HttpNotFound();
            }
            return View(ptaCategories);
        }

        // POST: PtaCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtaId,PtaCategoryName")] PtaCategories ptaCategories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaCategories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptaCategories);
        }

        // GET: PtaCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaCategories ptaCategories = db.PtaCategories.Find(id);
            if (ptaCategories == null)
            {
                return HttpNotFound();
            }
            return View(ptaCategories);
        }

        // POST: PtaCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtaCategories ptaCategories = db.PtaCategories.Find(id);
            db.PtaCategories.Remove(ptaCategories);
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
