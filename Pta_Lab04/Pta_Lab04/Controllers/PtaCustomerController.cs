using Pta_Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pta_Lab04.Controllers
{
    public class PtaCustomerController : Controller
    {
        // GET: PtaCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PtaCustomerDetails() {
            PtaCustomer ptaCus = new PtaCustomer()
            {
                CustomerID = "011",
                CustomerName = "Phan Truong Anh",
                Address = "ThaiBinh",
                YearOfBirth = 2004
            };
            ViewBag.customer = ptaCus;
            return View();

        }

        public ActionResult PtaListCustomer()
        {
            List<PtaCustomer> list = new List<PtaCustomer>()
            {
                new PtaCustomer()
                {
                    CustomerID = "012",
                    CustomerName = "Phan Truong Anh",
                    Address = "ThaiBinh",
                    YearOfBirth = 2004
                },
                new PtaCustomer()
                {
                    CustomerID = "01232",
                    CustomerName = "Phan TA Anh",
                    Address = "ThaiBinh",
                    YearOfBirth = 2004
                },
                new PtaCustomer()
                {
                    CustomerID = "012",
                    CustomerName = "Phan HEHE",
                    Address = "ThaiBinh",
                    YearOfBirth = 2004
                },
            };
            return View(list);
        }

        public ActionResult PtaCreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PtaCreateCustomer(PtaCustomer ptaCus) 
        {
            string info= "id"+ ptaCus.CustomerID;
            info += "name" + ptaCus.CustomerName;
            info += "address" + ptaCus.Address;
            info += "namsinh" + ptaCus.YearOfBirth;
            return Content(info);
        }
    }
}