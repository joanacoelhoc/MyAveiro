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

        public ActionResult Index()
        {
            List<String> listImagemRepository = GetAvailableImagesFromRepository();

            return View(listImagemRepository);
        }


        public ActionResult Aveiro()
        {
            return View();
        }

        public List<string> GetAvailableImagesFromRepository()
        {
            return db.ImagesRepository.Select(i => i.URLImage).ToList();
        }
    }
}