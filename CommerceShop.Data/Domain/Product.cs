using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommerceShop.Data.Domain
{
    [Table("Product")]
    public class Product : BaseEntity, IAuditEntity
    {
        private IList<ProductCategoryMapping> _productCategories;

        public Product()
        {
            _productCategories = new List<ProductCategoryMapping>();
        }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }

        //
        public int CreatedUserId { get; set; }

        public DateTime CreatedDate { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }

        public IList<ProductCategoryMapping> ProductCategories { get; set; }
    }
}