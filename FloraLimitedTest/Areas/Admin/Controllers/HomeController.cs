﻿using System.Web.Mvc;

namespace FloraLimitedTest.Areas.Admin.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}