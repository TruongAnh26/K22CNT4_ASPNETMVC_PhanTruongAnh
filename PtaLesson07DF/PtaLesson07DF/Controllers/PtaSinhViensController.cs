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
    public class PtaSinhViensController : Controller
    {
        private PtaLesson07DFEntities db = new PtaLesson07DFEntities();

        // GET: PtaSinhViens
        public ActionResult PtaIndex()
        {
            return View(db.PtaSinhViens.ToList());
        }

        // GET: PtaSinhViens/Details/5
        public ActionResult PtaDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaSinhVien ptaSinhVien = db.PtaSinhViens.Find(id);
            if (ptaSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptaSinhVien);
        }

        // GET: PtaSinhViens/Create
        public ActionResult PtaCreate()
        {
            return View();
        }

        // POST: PtaSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate([Bind(Include = "PtaMaSV,PtaTenSV,PtaPhone,PtaEmail,PtaPhai,PtaMaKH")] PtaSinhVien ptaSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.PtaSinhViens.Add(ptaSinhVien);
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }

            return View(ptaSinhVien);
        }

        // GET: PtaSinhViens/Edit/5
        public ActionResult PtaEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaSinhVien ptaSinhVien = db.PtaSinhViens.Find(id);
            if (ptaSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptaSinhVien);
        }

        // POST: PtaSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit([Bind(Include = "PtaMaSV,PtaTenSV,PtaPhone,PtaEmail,PtaPhai,PtaMaKH")] PtaSinhVien ptaSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }
            return View(ptaSinhVien);
        }

        // GET: PtaSinhViens/Delete/5
        public ActionResult PtaDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaSinhVien ptaSinhVien = db.PtaSinhViens.Find(id);
            if (ptaSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(ptaSinhVien);
        }

        // POST: PtaSinhViens/Delete/5
        [HttpPost, ActionName("PtaDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtaSinhVien ptaSinhVien = db.PtaSinhViens.Find(id);
            db.PtaSinhViens.Remove(ptaSinhVien);
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
