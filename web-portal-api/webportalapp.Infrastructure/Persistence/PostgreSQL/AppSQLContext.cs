using Microsoft.EntityFrameworkCore;
using webportalapp.Domain.Entities;

namespace webportalapp.Infrastructure.Persistence.PostgreSQL
{
    public class AppSQLContext : DbContext
    {
        public AppSQLContext(DbContextOptions<AppSQLContext> options) : base(options){

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(q => q.UID);
        }
    }
}
