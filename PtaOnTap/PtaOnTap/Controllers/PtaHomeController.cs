using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtaOnTap.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}