using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b>default</b> action";
        }
        //
        // GET: Helloworld/Welcome
        public string Welcome(string name, int ID)
        {
            return HttpUtility.HtmlAttributeEncode("hello " + name + ID);
        }
    }
}