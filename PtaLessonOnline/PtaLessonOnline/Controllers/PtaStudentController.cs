using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtaLessonOnline.Controllers
{
    public class PtaStudentController : Controller
    {
        // GET: PtaStudent
        /// <summary>
        /// author: Phan Trường Anh
        /// class: k22cnt4
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.fullname = "Phan Trường Anh";
            ViewData["Birthday"] = "26/01/2004";
            TempData["Phone"] = "0333814312";
            return View();
        }

        public ActionResult Details()
        {
            string ptaStr = "";
            ptaStr += "<h3>Họ và tên: Phan Trường Anh </h3>";
            ptaStr += "<p>Mã số 2210900 </p>";
           
            ViewBag.Details= ptaStr;
            return View("chiTiet");
        }

        public ActionResult NgonNguRazor()
        {
            return View();
        }
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            string fullName = form["fullName"];
            string maSV = form["MaSV"];

            string taikhoan = form["taiKhoan"];
            string matkhau = form["passWord"];

            string ptaStr = "<h3>" + fullName + "</h3>";
            ptaStr += "<p>" + maSV;
            ptaStr += "<p>" + taikhoan;
            ptaStr += "<p>" + matkhau;

            ViewBag.info = ptaStr;
            return View("KetQua");
        }
    }
}