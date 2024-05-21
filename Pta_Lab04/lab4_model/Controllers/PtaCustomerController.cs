using lab4_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace lab4_model.Controllers
{
    public class PtaCustomerController : Controller
    {
        // GET: PtaCustomer
        public ActionResult PtaCustomerDetail()
        {
            PtaCustomer cus = new PtaCustomer()
            {
                PtaCustomId = "001",
                PtaFullName = "Phan Trường Anh",
                Address = "Thái Bình",
                Email = "anhnganh04@gmail.com"
            };
            return View(cus);
        }

        public ActionResult PtaCustomerList() {
            List<PtaCustomer> listCustomer = new List<PtaCustomer>() {
                new PtaCustomer() {PtaCustomId = "001",
                PtaFullName = "Phan Trường Anh",
                Address = "Thái Bình",
                Email = "anhnganh04@gmail.com"},
                new PtaCustomer() {PtaCustomId = "002",
                PtaFullName = "Phan Trường ",
                Address = "Thái Ha",
                Email = "anhnganh04@gmail.com"},
                new PtaCustomer() {PtaCustomId = "003",
                PtaFullName = "Phan  Anh",
                Address = "Bình Duong",
                Email = "anhnganh04@gmail.com"},
            };
            ViewBag.listCustomer = listCustomer;
            return View();
        }
    }
}