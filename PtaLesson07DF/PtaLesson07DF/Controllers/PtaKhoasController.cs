using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtaLesson07DF.Models;

namespace PtaLesson07DF.Controllers
{
    public class PtaKhoasController : Controller
    {
        private PtaLesson07DFEntities db = new PtaLesson07DFEntities();

        // GET: PtaKhoas
        public ActionResult PtaIndex()
        {
            return View(db.PtaKhoas.ToList());
        }

        // GET: PtaKhoas/Details/5
        public ActionResult PtaDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaKhoa ptaKhoa = db.PtaKhoas.Find(id);
            if (ptaKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptaKhoa);
        }

        // GET: PtaKhoas/Create
        public ActionResult PtaCreate()
        {
            return View();
        }

        // POST: PtaKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate([Bind(Include = "PtaMaKH,PtaTenKH,PtaTrangThai")] PtaKhoa ptaKhoa)
        {
            if (ModelState.IsValid)
            {
                db.PtaKhoas.Add(ptaKhoa);
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }

            return View(ptaKhoa);
        }

        // GET: PtaKhoas/Edit/5
        public ActionResult PtaEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaKhoa ptaKhoa = db.PtaKhoas.Find(id);
            if (ptaKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptaKhoa);
        }

        // POST: PtaKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit([Bind(Include = "PtaMaKH,PtaTenKH,PtaTrangThai")] PtaKhoa ptaKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }
            return View(ptaKhoa);
        }

        // GET: PtaKhoas/Delete/5
        public ActionResult PtaDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaKhoa ptaKhoa = db.PtaKhoas.Find(id);
            if (ptaKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ptaKhoa);
        }

        // POST: PtaKhoas/Delete/5
        [HttpPost, ActionName("PtaDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtaKhoa ptaKhoa = db.PtaKhoas.Find(id);
            db.PtaKhoas.Remove(ptaKhoa);
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
