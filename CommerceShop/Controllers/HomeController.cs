using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CommerceShop.Data;
using CommerceShop.Data.Domain;
using CommerceShop.Service.Repository;

namespace CommerceShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new List<Category>();
            ServiceCategory serviceCategory = new ServiceCategory();
            serviceCategory.InsertCategory(new Category
            {
                Name = "Chimino",
                ParentId = 0,
                ShortDescription = null,
                LongDescription = null,
                PictureId = 0,
                CreatedDate = DateTime.Now,
                CreatedUserId = 0,
                UpdateDate = DateTime.Now,
                UpdateUserId = 0
            });

            return View(model);
        }
    }
}