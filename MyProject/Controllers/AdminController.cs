using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    [AdminMod]
    public class AdminController : BaseController
    {
        // GET: Admin
        public ActionResult Index()
        {

            return View();
        }
    }
}