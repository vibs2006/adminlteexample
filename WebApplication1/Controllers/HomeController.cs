﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //System.Threading.Thread.Sleep(2000);
            return View();
        }

        public ActionResult SampleBoxTable()
        {
            return View();
        }

        public ActionResult MagicInfoBoxes()
        {
            return View();
        }

        public ActionResult UnderConstruction()
        {
            return View();
        }
    }
}