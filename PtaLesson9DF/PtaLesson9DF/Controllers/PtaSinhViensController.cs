using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtaLesson9DF.Models;

namespace PtaLesson9DF.Controllers
{
    public class PtaSinhViensController : Controller
    {
        private PtaLesson9DFEntities db = new PtaLesson9DFEntities();

        // GET: PtaSinhViens
        public ActionResult PtaIndex()
        {
            var sinhViens = db.SinhViens.Include(s => s.Khoa);
            return View(sinhViens.ToList());
        }

        // GET: PtaSinhViens/Details/5
        public ActionResult PtaDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // GET: PtaSinhViens/Create
        public ActionResult PtaCreate()
        {
            ViewBag.MaKH = new SelectList(db.Khoas, "MaKH", "TenKH");
            return View();
        }

        // POST: PtaSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate([Bind(Include = "MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong,DiemTB")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhViens.Add(sinhVien);
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }

            ViewBag.MaKH = new SelectList(db.Khoas, "MaKH", "TenKH", sinhVien.MaKH);
            return View(sinhVien);
        }

        // GET: PtaSinhViens/Edit/5
        public ActionResult PtaEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.Khoas, "MaKH", "TenKH", sinhVien.MaKH);
            return View(sinhVien);
        }

        // POST: PtaSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit([Bind(Include = "MaSV,HoSV,TenSV,Phai,NgaySinh,NoiSinh,MaKH,HocBong,DiemTB")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PtaIndex");
            }
            ViewBag.MaKH = new SelectList(db.Khoas, "MaKH", "TenKH", sinhVien.MaKH);
            return View(sinhVien);
        }

        // GET: PtaSinhViens/Delete/5
        public ActionResult PtaDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // POST: PtaSinhViens/Delete/5
        [HttpPost, ActionName("PtaDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SinhVien sinhVien = db.SinhViens.Find(id);
            db.SinhViens.Remove(sinhVien);
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
