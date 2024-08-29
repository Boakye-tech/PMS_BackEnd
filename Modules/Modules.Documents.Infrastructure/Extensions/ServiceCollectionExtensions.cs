// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Extensions/ServiceCollectionExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:00 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Modules.Documents.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDocumentsInfrastructure(this IServiceCollection services, IConfiguration config, IHostEnvironment env)
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
}

