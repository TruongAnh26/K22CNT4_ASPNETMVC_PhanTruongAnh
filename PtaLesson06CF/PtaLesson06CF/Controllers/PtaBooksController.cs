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
    public class PtaBooksController : Controller
    {
        private PtaBookStore db = new PtaBookStore();

        // GET: PtaBooks
        public ActionResult Index()
        {
            return View(db.PtaBooks.ToList());
        }

        // GET: PtaBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaBook ptaBook = db.PtaBooks.Find(id);
            if (ptaBook == null)
            {
                return HttpNotFound();
            }
            return View(ptaBook);
        }

        // GET: PtaBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtaBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtaId,PtaBookId,PtaTitle,PtaAuthor,PtaYear,PtaPublisher,PtaCategoryID")] PtaBook ptaBook)
        {
            if (ModelState.IsValid)
            {
                db.PtaBooks.Add(ptaBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptaBook);
        }

        // GET: PtaBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaBook ptaBook = db.PtaBooks.Find(id);
            if (ptaBook == null)
            {
                return HttpNotFound();
            }
            return View(ptaBook);
        }

        // POST: PtaBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtaId,PtaBookId,PtaTitle,PtaAuthor,PtaYear,PtaPublisher,PtaCategoryID")] PtaBook ptaBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptaBook);
        }

        // GET: PtaBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaBook ptaBook = db.PtaBooks.Find(id);
            if (ptaBook == null)
            {
                return HttpNotFound();
            }
            return View(ptaBook);
        }

        // POST: PtaBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtaBook ptaBook = db.PtaBooks.Find(id);
            db.PtaBooks.Remove(ptaBook);
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
