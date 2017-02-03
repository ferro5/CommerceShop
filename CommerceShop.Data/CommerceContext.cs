using System.ComponentModel.DataAnnotations.Schema;
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
            modelBuilder.Entity<Category>().ToTable("Category")
                .HasKey<int>(p => p.Id)
                //.Property(p=>p.Name).HasMaxLength(50)
                //.IsRequired();
                .Property(p => p.ShortDescription)
                .HasMaxLength(250);
            modelBuilder.Entity<Category>()
                .Property(p => p.LongDescription)

                .HasMaxLength(600)
                .IsOptional();

            modelBuilder.Entity<ProductCategoryMapping>()
                .ToTable("Product_Category_Mapping")
                .Property(pm => pm.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}