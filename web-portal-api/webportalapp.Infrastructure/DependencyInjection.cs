using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace webportalapp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services, IConfiguration configuration) {
            #region Config PostgreSQLServer Database
            services.AddDbContext<Persistence.PostgreSQL.AppSQLContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("localpostgresql");
                options.UseNpgsql(connectionString);
            });
            #endregion
            return services;
        }
    }
}
