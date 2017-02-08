using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommerceShop.Data.Domain;
using CommerceShop.Service.Products;

namespace CommerceShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService = null;

        public ProductController()
        {
            _productService = new ProductService();
        }

        // GET: Product
        public ActionResult HomePageProducts()
        {
            var model = _productService.GetHonePageProduct();

            return View(model);
        }
    }
}