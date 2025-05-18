// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Modules.Users.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserInfrastructure(this IServiceCollection services, IConfiguration config, IHostEnvironment env)
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


            //services
            //    .AddDbContext<UserDbContext>(options => options.UseSqlServer(config.GetConnectionString("MsSQLConnection")));

            services
              .AddDbContext<UserDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}

