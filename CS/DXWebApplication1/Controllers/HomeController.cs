﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CallbackPanelPartial() {
            System.Threading.Thread.Sleep(1000);
            return PartialView();
        }
    }
}