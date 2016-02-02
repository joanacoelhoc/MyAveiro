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


        // GET: FunTypes/Museum
        public ActionResult Museum()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Museum").ToList());
        }

    
        // GET: FunTypes/Beach
        public ActionResult Beach()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Beach").ToList());
        }

        
        // GET: FunTypes/OutdoorActivities
        public ActionResult OutdoorActivities()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Outdoor Activities").ToList());
        }

        // GET: FunTypes/BarsPubs
        public ActionResult BarsPubs()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Fun" && i.FunTypes.FunTypeName == "Bars & Pubs").ToList());
        }

        // GET: FunTypes/Details/5
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

        

    }
}