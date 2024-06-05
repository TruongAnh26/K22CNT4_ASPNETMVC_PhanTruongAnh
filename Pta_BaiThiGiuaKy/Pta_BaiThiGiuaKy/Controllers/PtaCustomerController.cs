using Pta_BaiThiGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pta_BaiThiGiuaKy.Controllers
{
    public class PtaCustomerController : Controller
    {
        public static List<PtaCustomer> ptaCustomers = new List<PtaCustomer>()
        {
            new PtaCustomer() {_221090087_CustId="2210900087",Pta_FullName="Phan Trường Anh",Pta_Address="Thái Bình",Pta_Email="anhnganh04@gmail.com",Pta_Phone="0333814312",Pta_Balance=1},
            new PtaCustomer() {_221090087_CustId="1",Pta_FullName="Phan Anh",Pta_Address="Hà Nội",Pta_Email="anh@gmail.com",Pta_Phone="02178712636",Pta_Balance=1},
            new PtaCustomer() {_221090087_CustId="2",Pta_FullName="Nguyễn Thị B",Pta_Address="Hà Đông",Pta_Email="Thinhd@gmail.com",Pta_Phone="0232311112",Pta_Balance=0}


        };
        // GET: PtaCustomer
        public ActionResult PtaIndex()
        {
            return View(ptaCustomers);
        }

        public ActionResult PtaCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PtaCreate(PtaCustomer ptacus)
        {
            ptaCustomers.Add(ptacus);
            return RedirectToAction("PtaIndex");
        }

        [HttpGet]
        public ActionResult PtaEdit(string Id)
        {
            var ptaCus = ptaCustomers.FirstOrDefault(c => c._221090087_CustId == Id);
            return View(ptaCus);
        }

        [HttpPost]
        public ActionResult PtaEdit(PtaCustomer ptaCus)
        {
            var ptacust = ptaCustomers.FirstOrDefault(c => c._221090087_CustId == ptaCus._221090087_CustId);
            ptacust.Pta_FullName = ptaCus.Pta_FullName;
            ptacust.Pta_Address = ptaCus.Pta_Address;
            ptacust.Pta_Phone = ptaCus.Pta_Phone;
            ptacust.Pta_Email = ptaCus.Pta_Email;
            ptacust.Pta_Balance = ptaCus.Pta_Balance;
            return RedirectToAction("PtaIndex");
        }

        public ActionResult PtaDetails(string Id)
        {
            var ptacus = ptaCustomers.FirstOrDefault(s=> s._221090087_CustId == Id);
            return View(ptacus);
        }

        public ActionResult PtaDelete(string Id)
        {
            var ptacus = ptaCustomers.FirstOrDefault(s=> s._221090087_CustId == Id);
            ptaCustomers.Remove(ptacus);
            return RedirectToAction("PtaIndex");
        }
    }
}