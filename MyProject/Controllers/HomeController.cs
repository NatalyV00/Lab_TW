using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sign_up()
        {
            return View();
        }
        public ActionResult Log_in()
        {
            return View();
        }
        public ActionResult Contact_us()
        {
            return View();
        }
    }
}