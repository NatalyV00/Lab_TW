using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Models;
using MyProject.Extension;

namespace MyProject.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            SessionStatus();
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            if (user == null)
            {
                return View();
            }

            UserData u = new UserData
            {
                Username = user.Username
            };
            return View(u);
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