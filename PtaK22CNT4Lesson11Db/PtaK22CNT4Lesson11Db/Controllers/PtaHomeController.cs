using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtaK22CNT4Lesson11Db.Controllers
{
    public class PtaHomeController : Controller
    {
        public ActionResult PtaIndex()
        {
            return View();
        }

        public ActionResult PtaAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PtaContact()
        {
            ViewBag.msv = "2210900087";
            ViewBag.fullname = "Phan Trường Anh";

            return View();
        }
    }
}