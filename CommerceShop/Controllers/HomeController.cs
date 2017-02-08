using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CommerceShop.Data;
using CommerceShop.Data.Domain;
using CommerceShop.Service.Products;

namespace CommerceShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            GenericUnitOfWork _uow = new GenericUnitOfWork();
            var product = new Product
            {
                Name = "Amfora",
                ShortDescription = "Suit",
                LongDescription = null,
                Price = 5000,
                ShowOnHomePage = true,
                CreatedDate = DateTime.Now,
                CreatedUserId = 0,
                UpdateDate = DateTime.Now,
                UpdateUserId = 0
            };
            _uow.Repository<Product>().Insert(product);
            _uow.SaveChanges();
            var model = new List<Category>();
            return View(model);
        }
    }
}