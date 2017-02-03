using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceShop.Data;
using CommerceShop.Data.Domain;

namespace CommerceShop.Service.Repository
{
    public class ServiceCategory : Data.IRepository<Category>
    {
        private CommerceContext _context;

        public ServiceCategory()
        {
            _context = new CommerceContext();
        }

        public IList<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(p => p.Id == id);
        }

        public Category InsertCategory(Category entity)
        {
            var category = _context.Categories.Add(entity);
            _context.SaveChanges();
            return category;
        }

        public void Update(Category entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            var result = _context.SaveChanges();
            if (result > 0)
                return true;
            return false;
        }
    }
}