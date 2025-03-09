using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Modules.Customers.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomerInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("MsSQLConnection")));


            return services;
        }
    }
}

