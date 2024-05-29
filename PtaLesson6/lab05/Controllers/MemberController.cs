using lab05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab05.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult PtaCreateOne()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PtaCreateOne(PtaMember m)
        {
            return View("PtaDetais",m);
        }

        public ActionResult PtaCreateTwo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PtaCreateTwo(PtaMember m)
        {
            if(m.Id == null)
            {
                ViewBag.error = "hay nhap ma so";
                return View();
            }
            if(m.PtaUserName == null)
            {
                ViewBag.error = "Hay nhap ten dang nhap";
                return View();
            }
            if(m.PtaAge == null)
            {
                ViewBag.error = "hay nhap tuoi";
                return View();
            }
            if(m.PtaPassword == null)
            {
                ViewBag.error = "hay nhap mat khau";
                return View();
            }
            return View("PtaDetais",m);
        }
        public ActionResult PtaCreateThree() { return View(); }
        [HttpPost]
        public ActionResult PtaCreateThree(PtaMember m )
        {
            if (ModelState.IsValid)
                return View("PtaDetais", m);
            else
                return View();
        }

        public ActionResult PtaDetais() { return View(); }
    }
}