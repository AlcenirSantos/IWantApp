using IWantAPP.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace IWantAPP.Repositories
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(255);

            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
            
            modelBuilder.Entity<Category>().Property(p => p.Name).IsRequired();
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(100);
        }
    }
}
