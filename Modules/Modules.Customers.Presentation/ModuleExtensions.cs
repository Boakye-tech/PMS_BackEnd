// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System;
using Azure.Storage.Blobs;


namespace Modules.Customers.Presentation
{
	public static class ModuleExtensions
	{
        public static IServiceCollection AddCustomerModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddCustomerInfrastructure(configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IPropertyDetailsService, PropertyDetailsService>();
            services.AddScoped<ICustomerDetailsService, CustomerDetailsService>();
            services.AddScoped<ICustomerTransactionsService, CustomerTransactionsService>();
            services.AddScoped<ICustomerPaymentsService, CustomerPaymentsService>();
            services.AddScoped<ICustomerInvoiceService, CustomerInvoiceService>();
            //services.AddScoped<ICustomerInvoiceItemsService, CustomerInvoiceItemsService>();

            services.AddScoped<IComplaintTypeService, ComplaintTypeService>();
            services.AddScoped<INatureOfComplaintService, NatureOfComplaintService>();
            services.AddScoped<IComplaintService, ComplaintService>();

            services.AddHttpClient<ICustomerModuleCommunicationServices, CustomerModuleCommunicationServices>();

            services.AddSingleton(s =>
            {
                return new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=mindspringsimagesonline;AccountKey=ZKa5Ph0zKTOgh64SGX9VyMcJEGnUHJhAckWaBKI7BJqa9ffMApgLdu6peQ1tma6T2XltQu+Kepwi+AStOJGeHA==;EndpointSuffix=core.windows.net");
            });
            services.AddScoped<IAzureBlobService, AzureBlobService>();


            // Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

