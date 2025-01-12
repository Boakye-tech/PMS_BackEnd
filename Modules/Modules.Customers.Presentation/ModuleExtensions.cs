using System;
using Modules.Customers.Domain.Interfaces;
using Modules.Customers.Infrastructure.Extensions;
using Modules.Customers.Infrastructure.Persistence.Repositories;

namespace Modules.Customers.Presentation
{
	public static class ModuleExtensions
	{
        public static IServiceCollection AddCustomerModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                //.AddCatalogCore()
                .AddCustomerInfrastructure(configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped<IAllocationTypeService, AllocationTypeService>();
            //services.AddScoped<IApartmentTypeService, ApartmentTypeService>();
            //services.AddScoped<IBlockNumberService, BlockNumberService>();
            //services.AddScoped<IBlockSideService, BlockSideService>();
            //services.AddScoped<IBlockTypeService, BlockTypeService>();
            //services.AddScoped<IBlockUnitService, BlockUnitService>();
         

            // Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

