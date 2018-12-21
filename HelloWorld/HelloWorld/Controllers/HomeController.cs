using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ContentResult Index()
        {
            return Content("HelloWorld, Here is the Home page");
        }
    }
}