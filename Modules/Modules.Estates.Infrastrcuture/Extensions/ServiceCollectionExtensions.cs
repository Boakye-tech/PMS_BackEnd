using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.Estates.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEstateInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services
            .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("MsSQLConnection")));


        return services;
    }
}

