using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommerceShop.Data;
using CommerceShop.Data.Domain;

namespace CommerceShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new List<Product>();
            using (CommerceContext context = new CommerceContext())
            {
                model = context.Products.ToList();
                return View(model);
            }
        }
    }
}