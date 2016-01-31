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
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.RestTypes.RestTypeName == "Museum").ToList());
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
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.RestTypes.RestTypeName == "Beach").ToList());
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
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.RestTypes.RestTypeName == "OutdoorActivities").ToList());
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
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.RestTypes.RestTypeName == "OutdoorActivities").ToList());
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
    }
}