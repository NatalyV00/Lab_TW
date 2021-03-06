﻿using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MyProject.BusinessLogic.Interfaces;
using MyProject.BusinessLogic;
using MyProject.Domain.Entities.User;
using MyProject.Models;

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
            /*
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            */

            if (ModelState.IsValid)
            {
                // Mapper.Initialize(cfg => cfg.CreateMap<UserLogin, ULoginData>());
                //var data = Mapper.Map<ULoginData>(login);

                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<UserLogin, ULoginData>();
                });

                IMapper mapper = config.CreateMapper();
                var source = new UserLogin();
                var data = mapper.Map<UserLogin, ULoginData>(source);

                data.LoginIp = Request.UserHostAddress;
                data.LoginDateTime = DateTime.Now;

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

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