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
    public class FunTypesController : Controller
    {
        private MyAveiroContext db = new MyAveiroContext();

        // GET: FoodTypes
        public ActionResult Index()
        {
            return View();
        }


        // GET: RestTypes/Museum
        public ActionResult Museum()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Museum").ToList());
        }

        // GET: Utilities/MuseumDetails/5
        public ActionResult MuseumDetails(int? id)
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

        // GET: RestTypes/Beach
        public ActionResult Beach()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Beach").ToList());
        }

        // GET: Utilities/BeachDetails/5
        public ActionResult BeachDetails(int? id)
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


        // GET: RestTypes/OutdoorActivities
        public ActionResult OutdoorActivities()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Outdoor Activities").ToList());
        }

        // GET: Utilities/OutdoorActivitiesDetails/5
        public ActionResult OutdoorActivitiesDetails(int? id)
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

        // GET: RestTypes/BarsPubs
        public ActionResult BarsPubs()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Bars & Pubs").ToList());
        }

        // GET: Utilities/BarsPubsDetails/5
        public ActionResult BarsPubsDetails(int? id)
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

        // GET: RestTypes/Details/5
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