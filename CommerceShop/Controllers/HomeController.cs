using System;
using System.Collections.Generic;
using System.Web.Mvc;
using CommerceShop.Data.Domain;
using CommerceShop.Service.Products;

namespace CommerceShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new List<Category>();
            //ServiceCategory serviceCategory = new ServiceCategory();
            //serviceCategory.Insert(new Category
            //{
            //    Name = "Chimino",
            //    ParentId = 0,
            //    ShortDescription = null,
            //    LongDescription = null,
            //    PictureId = 0,
            //    CreatedDate = DateTime.Now,
            //    CreatedUserId = 0,
            //    UpdateDate = DateTime.Now,
            //    UpdateUserId = 0
            //});
            ProductService _productService = new ProductService();
            _productService.Insert(new Product
            {
                Name = "Amfora",
                ShortDescription = "Suit",
                LongDescription = "Itallian Suit",
                CostPrice = 1500,
                Price = 5000,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                UpdateDate = DateTime.Now,
            });

            _productService.SaveChanges();

            return View(model);
        }
    }
}