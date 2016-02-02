using MyAveiro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAveiro.Controllers
{
    public class HomeController : Controller
    {
        private MyAveiroContext db = new MyAveiroContext();

        // GET: Home
        public ActionResult Index()
        {
            List<String> listImagemRepository = GetAvailableImagesFromRepository();

            return View(listImagemRepository);
        }

        // GET: Home/Aveiro
        public ActionResult Aveiro()
        {
            return View();
        }

        public List<string> GetAvailableImagesFromRepository()
        {
            return db.ImagesRepository.Where(i => i.Utilities.UtilitiesTypes.UtilityTypeName != "Police"
                && i.Utilities.UtilitiesTypes.UtilityTypeName != "Transport" 
                && i.Utilities.UtilitiesTypes.UtilityTypeName!="Emergency").Select(i => i.URLImage).ToList();
        }
    }
}