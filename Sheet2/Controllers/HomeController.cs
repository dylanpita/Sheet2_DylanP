﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hom
        public ActionResult Index()
        {
            return View();
        }
    }
}