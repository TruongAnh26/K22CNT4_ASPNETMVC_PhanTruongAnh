using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "Chào Mừng bạn đến với ASP.NET MVC 5";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.message = "Đây là trang About";
            return View();
        }
    }

}