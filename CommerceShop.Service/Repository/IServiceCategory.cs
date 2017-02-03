using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceShop.Data.Domain;

namespace CommerceShop.Service.Repository
{
    public interface IServiceCategory
    {
        IList<Category> GetAll();

        Category GetById(int id);

        Category InsertCategory(Category category);

        Category UpdateCategory(Category category);

        bool DeleteCategory(Category category);
    }
}