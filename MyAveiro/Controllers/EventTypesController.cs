using MyAveiro.DAL;
using MyAveiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyAveiro.Controllers
{
    public class EventTypesController : Controller
    {
        private MyAveiroContext db = new MyAveiroContext();

        // GET: EventTypes
        public ActionResult Index()
        {
            return View();
        }


        // GET: EventTypes/Exhibitions
        public ActionResult Exhibitions()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Event" && i.EventTypes.EventTypeName == "Exhibitions").ToList());
        }

        // GET: EventTypes/ExhibitionsDetails/5
        public ActionResult ExhibitionsDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilities utilities = db.Utilities.Find(id);
            if (utilities == null)
            {
                return HttpNotFound();
            }
            return View(utilities);
        }

        // GET: EventTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilities utilities = db.Utilities.Find(id);
            if (utilities == null)
            {
                return HttpNotFound();
            }
            return View(utilities);
        }

        //public ActionResult ImagesRepositoryPartial(string Acronym)
        //{
        //    List<String> listImagemRepository = GetAvailableImagesFromRepository(Acronym);
        //    return PartialView("_ImageDetails", listImagemRepository);

        //}

        //public List<string> GetAvailableImagesFromRepository(string Acronym)
        //{
        //    if (Acronym != null && Acronym != string.Empty)
        //        return db.ImagesRepository.Where(i => i.Utilities.Acronym == Acronym).Select(i => i.URLImage).ToList();
        //    else
        //        return new List<string>();
        //}


    }
}