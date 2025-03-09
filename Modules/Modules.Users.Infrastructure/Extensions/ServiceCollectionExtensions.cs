using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.Users.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDbContext<UserDbContext>(options => options.UseSqlServer(config.GetConnectionString("MsSQLConnection")));


            return services;
        }
    }
}

