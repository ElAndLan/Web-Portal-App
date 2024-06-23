using Microsoft.EntityFrameworkCore;
using webportalapp.Domain.Entities;

namespace webportalapp.Infrastructure.Persistence.PostgreSQL
{
    public class AppSQLContext : DbContext
    {
        public AppSQLContext(DbContextOptions<AppSQLContext> options) : base(options){

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(q => q.UID);

            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasKey(q => q.Id);

            modelBuilder.Entity<Purchase>().ToTable("Purchases");
            modelBuilder.Entity<Purchase>().HasKey(q => q.Id);
        }
    }
}
