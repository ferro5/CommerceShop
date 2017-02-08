using System.Collections.Generic;
using System.Linq;
using CommerceShop.Data;
using CommerceShop.Data.Domain;

namespace CommerceShop.Service.Products
{
    public class ProductService : IProductService
    {
        private GenericUnitOfWork _unitOfWork = null;

        public ProductService()
        {
            _unitOfWork = new GenericUnitOfWork();
        }

        public List<Product> GetHonePageProduct()
        {
            var products = _unitOfWork.Repository<Product>().Where(p => p.ShowOnHomePage).ToList();
            return products;
        }
    }
}