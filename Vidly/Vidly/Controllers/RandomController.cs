using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class RandomController : Controller
    {
        // GET: Random
        //public ActionResult View()
        //{
        //    var liczba = new Vidly.Models.Random();
        //    var r = new System.Random();
        //    liczba.Liczba = r.Next(1,39);
        //    return View(liczba);
        //}
        
        public ActionResult View(int Od, int Do)
        {
            var liczba = new Vidly.Models.Random();
            var r = new System.Random();
            liczba.Liczba = r.Next(Od, Do);
            return View(liczba);
        }

    }
}