using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MyProject.BusinessLogic;
using MyProject.BusinessLogic.Interfaces;
using MyProject.Domain.Entities.User;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class RegisterController : Controller
    { 
         private readonly IRegister _register;
         private readonly ISession _session;
            // GET: Login
            public RegisterController()
            {
                var bl = new BusinessLogic.BussinesLogic();
                _register = bl.GetRegisterBL();
                var ss = new BusinessLogic.BussinesLogic();
                _session = ss.GetSessionBL();
            }

            public ActionResult Index()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Index(UsersDbTable user)
            {
                UsersDbTable data = new UsersDbTable
                {
                    Username = user.Username,
                    Email = user.Email,
                    Password = user.Password,
                    
                };

                _register.UserRegisterData(data);

                ULoginData u = new ULoginData
                {
                    Credential = user.Username,
                    Password = user.Password
                };

                _session.UserLogin(u);

                HttpCookie cookie = _session.GenCookie(u.Credential);
                ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                return RedirectToAction("Index", "Home");
            }
        }
    }