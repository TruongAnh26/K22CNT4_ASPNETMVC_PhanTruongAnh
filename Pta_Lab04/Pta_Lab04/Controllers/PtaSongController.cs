using Pta_Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pta_Lab04.Controllers
{
    public class PtaSongController : Controller
    {
        public static List<PtaSong> cateLogs = new List<PtaSong>()
        {
            new PtaSong()
            {
                Id=1,
                Name="Biển tình",
                Author="Fanta",
                Artist="keke"
            },            
            new PtaSong()
            {
                Id=2,
                Name="Xin Chào",
                Author="Hehe",
                Artist="Phương"
            },
            new PtaSong()
            {
                Id=3,
                Name="Biển tình",
                Author="Linh",
                Artist="Naxus"
            },

        };
        // GET: PtaSong
        public ActionResult Index()
        {
            return View(cateLogs);
        }

        public ActionResult PtaCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PtaCreate(PtaSong song)
        {
            cateLogs.Add(song);
            return Redirect("Index");
        }
        
        public ActionResult PtaEdit(int? id)
        {
            var song = cateLogs.FirstOrDefault(x => x.Id == id);
            return View(song);
        }
        [HttpPost]
        public ActionResult PtaEdit(PtaSong song)
        {
            var so = cateLogs.FirstOrDefault(x =>x.Id == song.Id);
            so.Name = song.Name;
            song.Author = song.Author;
            song.Artist = song.Artist;
            return RedirectToAction("Index");
        }
        public ActionResult PtaDetail(int? id)
        {
            var song = cateLogs.FirstOrDefault(y => y.Id == id);
            return View(song);
        }
        public ActionResult PtaDelete(int? id)
        {
            var song = cateLogs.FirstOrDefault(x => x.Id==id);
            cateLogs.Remove(song);
            return RedirectToAction("Index");
        }
    }
}