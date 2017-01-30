using System.Data.Entity;
using CommerceShop.Data.Domain;

namespace CommerceShop.Data
{
    public class CommerceContext : DbContext
    {
        public CommerceContext() : base("commerce")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CommerceContext>());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product").HasKey<int>(p => p.Id);
            modelBuilder.Entity<Category>().ToTable("Category").HasKey<int>(p => p.Id);
            modelBuilder.Entity<ProductCategoryMapping>().ToTable("ProductCategoryMapping");
        }
    }
}