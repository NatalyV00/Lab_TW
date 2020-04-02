using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Mvc;
using MyProject.BusinessLogic;
using MyProject.BusinessLogic.Core;
using MyProject.BusinessLogic.Interfaces;
using MyProject.Models;
using MyProject.Domain.Entities.User;
using ISession = MyProject.BusinessLogic.Interfaces.ISession;

namespace MyProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    //ADD COOKIE
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();

                }
            }

            return View();
        }
    }
}
