using PtaK22CNT4LS10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtaK22CNT4LS10.Controllers
{
    public class PtaHomeController : Controller
    {
        public ActionResult PtaIndex()
        {
            if (Session["PtaAccount"] != null)
            {
                var ptaAccount = Session["PtaAccount"] as PtaAccount;
                ViewBag.FullName = ptaAccount.PtaFullName;
            }
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