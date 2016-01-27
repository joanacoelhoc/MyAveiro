﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyAveiro.DAL;
using MyAveiro.Models;

namespace MyAveiro.Controllers
{
    public class UtilitiesController : Controller
    {
        private MyAveiroContext db = new MyAveiroContext();

        // GET: Utilities
        public ActionResult Index()
        {
            return View(db.Utilities.ToList());
        }
       
        // GET: Utilities/Emergency
        public ActionResult Emergency()
        {
            return View(db.Utilities.Where(i => i.UtilityID == 1).ToList());
        }

        // GET: Utilities/Transports
        public ActionResult Transports()
        {
            return View(db.Utilities.Where(i=>i.UtilityID==2).ToList());
        }

        // GET: Utilities/Police
        public ActionResult Police()
        {
            return View(db.Utilities.Where(i => i.UtilityID == 3).ToList());
        }

        // GET: Utilities/Details/5
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
