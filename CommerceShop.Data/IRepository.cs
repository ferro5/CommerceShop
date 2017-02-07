using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CommerceShop.Data
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();

        IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        TEntity Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        int SaveChanges();
    }
}