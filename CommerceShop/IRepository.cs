using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceShop.Data.Domain;

namespace CommerceShop
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity InsertCategory(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}