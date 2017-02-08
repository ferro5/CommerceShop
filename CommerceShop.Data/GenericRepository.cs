using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using CommerceShop.Data.Domain;

namespace CommerceShop.Data
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity

    {
        private CommerceContext _context;

        public GenericRepository(CommerceContext context)
        {
            _context = context;
        }

        public CommerceContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public virtual IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            var result = _context.Set<TEntity>().Where(predicate);
            return result.ToList();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            var result = _context.Set<TEntity>().Add(entity);
            return result;
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        //public virtual int SaveChanges()
        //{
        //    return _context.SaveChanges();
        //}
    }
}