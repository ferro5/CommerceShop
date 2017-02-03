using System.Collections.Generic;
using CommerceShop.Data.Domain;

namespace CommerceShop.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity InsertCategory(TEntity entity);

        void Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}