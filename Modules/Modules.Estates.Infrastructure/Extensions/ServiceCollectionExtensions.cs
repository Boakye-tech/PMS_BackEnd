// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Modules.Estates.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEstateInfrastructure(this IServiceCollection services, IConfiguration config, IHostEnvironment env)
    {
        string? connectionString = null!;


        if (env.IsDevelopment())
        {
            connectionString = config.GetConnectionString("MsSQLConnection_Development");
        }

        if (env.IsStaging())
        {
            connectionString = config.GetConnectionString("MsSQLConnection_Staging");
        }

        if (env.IsProduction())
        {
            connectionString = config.GetConnectionString("MsSQLConnection");
        }

        services
            .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


        return services;
    }
}

