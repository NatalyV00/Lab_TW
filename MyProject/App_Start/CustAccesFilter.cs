﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MyProject.BusinessLogic.Interfaces;
using MyProject.BusinessLogic;
//using MyProject.Domain.Entities.User;
using MyProject.Domain.Enums;
using MyProject.Extension;

namespace MyProject
{
    public class AdminModAttribute : ActionFilterAttribute
    {
        private readonly ISession _sessionBusinessLogic;

        public AdminModAttribute()
        {
            var businessLogic = new BussinesLogic();
            _sessionBusinessLogic = businessLogic.GetSessionBL();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
            if (apiCookie != null)
            {
                var profile = _sessionBusinessLogic.GetUserByCookie(apiCookie.Value);
                if (profile != null && profile.Level != URole.Admin)
                {
                    HttpContext.Current.SetMySessionObject(profile);
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(new { controller = "Error", action = "Error404" }));
                }
            }
        }
    }
}