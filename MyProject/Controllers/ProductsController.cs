using MyProject.BusinessLogic.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class ProductsController : Controller
    {
        ProductsContext db = new ProductsContext();
        // GET: Products
        public ViewResult Index()
        {
            return View();
           // return View(db.Products.ToList());
        }
    }
}