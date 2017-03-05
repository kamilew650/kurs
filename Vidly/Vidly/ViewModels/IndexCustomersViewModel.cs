using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class IndexCustomersViewModel
    {
        public int Ile;
        public List<Customer> Customers { get; set; }
    }
}