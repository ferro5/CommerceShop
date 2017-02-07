using System.Collections.Generic;
using System.Linq;
using CommerceShop.Data;
using CommerceShop.Data.Domain;

namespace CommerceShop.Service.Repository
{
    public class ServiceCategory : GenericRepository<CommerceContext, Category>, IServiceCategory
    {
        public IList<Category> GetSubCategoriesById(int categoryId)
        {
            return this.Where(p => p.ParentId == categoryId).ToList();
        }
    }
}