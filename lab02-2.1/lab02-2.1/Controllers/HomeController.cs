using lab02_2._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab02_2._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestViewResult()
        {

            return View();
        }

        public PartialViewResult TestPartialViewResult()
        {

            return PartialView();
        }
        public EmptyResult TestEmptyResult() 
        {

            return new EmptyResult ();
        }
        public RedirectResult TestRedirectResult()
        {

            return Redirect("Index");
        }
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student() { Id = 001, Name= "Phan Trường Anh", ClassName="C1311L"});
            listStudent.Add(new Student() { Id = 001, Name= "Nguyễn Duy Quang", ClassName="C1311T"});
            listStudent.Add(new Student() { Id = 001, Name= "Nguyễn Duy Anh", ClassName="C1311C"});
            listStudent.Add(new Student() { Id = 001, Name= "Phan Ta", ClassName="C1311L"});
            return Json(listStudent,JsonRequestBehavior.AllowGet);
        }
    }
}