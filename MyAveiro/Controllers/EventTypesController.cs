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

        // GET: FoodTypes
        public ActionResult Index()
        {
            return View();
        }


        // GET: RestTypes/Exhibitions
        public ActionResult Exhibitions()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Event" && i.RestTypes.RestTypeName == "Exhibitions").ToList());
        }

        // GET: Utilities/ExhibitionsDetails/5
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
    }
}