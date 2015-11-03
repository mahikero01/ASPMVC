using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public String Index()
        {
            return "This is my <b>default</b> actioon..";
        }

        public String Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode( "Hello " + name + ", ID: " + ID);
        }
    }
}