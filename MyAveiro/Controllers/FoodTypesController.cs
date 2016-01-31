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
    public class FoodTypesController : Controller
    {
        private MyAveiroContext db = new MyAveiroContext();

        // GET: FoodTypes
        public ActionResult Index()
        {
            return View();
        }


        // GET: RestTypes/Restaurants
        public ActionResult Restaurants()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Food" && i.RestTypes.RestTypeName == "Restaurant").ToList());
        }
        // GET: Utilities/RestaurantsDetails/5
        public ActionResult RestaurantsDetails(int? id)
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