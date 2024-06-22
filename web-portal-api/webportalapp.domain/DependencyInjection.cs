using Microsoft.Extensions.DependencyInjection;

namespace webportalapp.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainDependency(this IServiceCollection services)
        {
            return services;
        }
    }
}
