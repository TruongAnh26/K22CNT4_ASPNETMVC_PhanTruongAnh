using PtaLesson6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PtaLesson6.Controllers
{
    public class PtaSongController : Controller
    {
        private static List<PtaSong> ptaSongs = new List<PtaSong>()
        {
            new PtaSong{Id=1,PtaTitle="Phan Trường Anh",PtaAuthor="K22CNT4",PtaArtist="NTU", PtaYearRelease=2024},
            new PtaSong{Id=2,PtaTitle="Phan Anh",PtaAuthor="K22CNT4",PtaArtist="NTU", PtaYearRelease=2024}

        };
        // GET: PtaSong
        public ActionResult Index()
        {
            return View(ptaSongs);
        }
        public ActionResult PtaCreate() {
            var ptaSong = new PtaSong();
            return View(ptaSong);
        }
    }
}