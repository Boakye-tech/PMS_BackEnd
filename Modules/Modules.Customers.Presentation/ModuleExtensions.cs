using System;
using Azure.Storage.Blobs;

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


            services.AddScoped(s => new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=mindspringsimagesonline;AccountKey=ZKa5Ph0zKTOgh64SGX9VyMcJEGnUHJhAckWaBKI7BJqa9ffMApgLdu6peQ1tma6T2XltQu+Kepwi+AStOJGeHA==;EndpointSuffix=core.windows.net"));
            services.AddScoped<IAzureBlobService, AzureBlobService>();


            // Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

