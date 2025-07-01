// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Presentation/ModuleExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 11:42 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Presentation
{
	public static class ModuleExtensions
	{
        public static IServiceCollection AddFacilitiesModule(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services.AddFacilitiesInfrastructure(configuration, environment);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICleanersService, CleanersService>();
            services.AddScoped<IItemsCategoryService, ItemsCategoryService>();
            services.AddScoped<IItemsService, ItemsService>();
            services.AddScoped<IServiceCategoryService, ServiceCategoryService>();
            services.AddScoped<IServiceProvidersService, ServiceProvidersService>();
            services.AddScoped<IServicesService, ServicesService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<ISuppliersService, SuppliersService>();

            //services.AddValidatorsFromAssemblyContaining<>();
           

            // Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
	}
}

