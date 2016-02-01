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
    public class RestTypesController : Controller
	{
        private MyAveiroContext db = new MyAveiroContext();

        // GET: RestTypes
        public ActionResult Index()
        {
            return View();
        }

        // GET: RestTypes/Hostels
        public ActionResult Hostels()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Rest" && i.RestTypes.RestTypeName == "Hostel").ToList());
        }

        // GET: RestTypes/HostelsDetails/5
        public ActionResult HostelDetails(int? id)
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

        // GET: RestTypes/Hotels
        public ActionResult Hotels()
        {
            return View(db.Utilities.Where(i => i.UtilitiesTypes.UtilityTypeName == "Rest" && i.RestTypes.RestTypeName == "Hotel").ToList());
        }

        // GET: RestTypes/HotelsDetails/5
        public ActionResult HotelDetails(int? id)
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
        //     //= "Buga";
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