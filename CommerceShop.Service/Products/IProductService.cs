using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceShop.Data.Domain;

namespace CommerceShop.Service.Products
{
    public interface IProductService
    {
        List<Product> GetHonePageProduct();
    }
}