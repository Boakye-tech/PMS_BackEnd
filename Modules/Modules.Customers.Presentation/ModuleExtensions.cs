using System;

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

            services.AddScoped<IPropertyDetailsService, PropertyDetailsService>();
            services.AddScoped<ICustomerDetailsService, CustomerDetailsService>();
            //services.AddScoped<ICustomerTransactionsService, CustomerTransactionsService>();
            //services.AddScoped<ICustomerPaymentsService, CustomerPaymentsService>();
            //services.AddScoped<ICustomerInvoiceService, CustomerInvoiceService>();
            //services.AddScoped<ICustomerInvoiceItemsService, CustomerInvoiceItemsService>();
         

            // Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

