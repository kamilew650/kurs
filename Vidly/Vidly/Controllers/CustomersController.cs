using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1", Id = 1 },
                new Customer { Name = "Customer 2", Id = 2 }
            };

            var c = new IndexCustomersViewModel
            {
                Ile = customers.Count(),
                Customers = customers
            };

            return View(c);
        }

        public ActionResult Details(int Id)
        {

            return View();
        }
    }
}