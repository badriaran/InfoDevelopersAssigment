using DataAcessLayer.Data;
using System;

namespace InfoAssigment.Web.IOC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            return services;
        }
    }
}
