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

        // GET: EventTypes/Exhibitions
        public ActionResult Exhibitions()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Event" && i.EventTypes.EventTypeName == "Exhibitions").ToList());
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

    }
}