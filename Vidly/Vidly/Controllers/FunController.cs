﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class FunController : Controller
    {
        // GET: Fun
        public ActionResult Index()
        {
            return View();
        }
    }
}