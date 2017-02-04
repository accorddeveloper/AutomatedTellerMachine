﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Serial(string lettercase)
        {
            var serial = "ASPNETMVC3ATM1";
            if(lettercase == "lower")
            {
                return Content(serial.ToLower());
            }
            return RedirectToAction("Index");
        }
    }
}