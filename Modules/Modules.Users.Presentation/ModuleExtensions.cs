using System;
using Modules.Users.Application.Interfaces;
using Modules.Users.Application.UseCases;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Infrastructure.Extensions;
using Modules.Users.Infrastructure.Repositories;

namespace Modules.Users.Presentation
{
	public static class ModuleExtensions
	{
        public static IServiceCollection AddUserModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddUserInfrastructure(configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentUnitService, DepartmentUnitService>();
            


            //// Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

