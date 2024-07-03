using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtaK22CNT4LS10.Models;

namespace PtaK22CNT4LS10.Controllers
{
    public class PtaAccountsController : Controller
    {
        private K22CNT4DFLESSON10Entities db = new K22CNT4DFLESSON10Entities();

        // GET: PtaAccounts
        public ActionResult Index()
        {
            return View(db.PtaAccount.ToList());
        }

        // GET: PtaAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaAccount ptaAccount = db.PtaAccount.Find(id);
            if (ptaAccount == null)
            {
                return HttpNotFound();
            }
            return View(ptaAccount);
        }

        // GET: PtaAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtaAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtaID,PtaUserName,PtaPassword,PtaFullName,PtaEmail,PtaPhone,PtaActive")] PtaAccount ptaAccount)
        {
            if (ModelState.IsValid)
            {
                db.PtaAccount.Add(ptaAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptaAccount);
        }

        // GET: PtaAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaAccount ptaAccount = db.PtaAccount.Find(id);
            if (ptaAccount == null)
            {
                return HttpNotFound();
            }
            return View(ptaAccount);
        }

        // POST: PtaAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtaID,PtaUserName,PtaPassword,PtaFullName,PtaEmail,PtaPhone,PtaActive")] PtaAccount ptaAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptaAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptaAccount);
        }

        // GET: PtaAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtaAccount ptaAccount = db.PtaAccount.Find(id);
            if (ptaAccount == null)
            {
                return HttpNotFound();
            }
            return View(ptaAccount);
        }

        // POST: PtaAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtaAccount ptaAccount = db.PtaAccount.Find(id);
            db.PtaAccount.Remove(ptaAccount);
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

        //login
        public ActionResult PtaLogin ()
        {
            var ptaModel = new PtaAccount();
            return View(ptaModel);
        }
        [HttpPost]
        public ActionResult PtaLogin(PtaAccount ptaAccount)
        {
           var ptaCheck = db.PtaAccount.Where(x=>x.PtaUserName.Equals(ptaAccount.PtaUserName) && x.PtaPassword.Equals(ptaAccount.PtaPassword)).FirstOrDefault();
           if(ptaCheck != null) {
                Session["PtaAccount"] = ptaCheck;
                return Redirect("/");
           }
            return View(ptaAccount);

        }
    }
}
