using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.Finance.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFinanceInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services
            .AddDbContext<FinanceDbContext>(options => options.UseSqlServer(config.GetConnectionString("MsSQLConnection")));


        return services;
    }
}

