// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Finance.Presentation
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddFinanceModule(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services
                .AddFinanceInfrastructure(configuration, environment);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBankBranchService, BankBranchService>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<IBankSortCodesService, BankSortCodesService>();
            services.AddScoped<IChartOfAccountsService, ChartOfAccountsService>();
            services.AddScoped<ICurrencyExchangeRateService, CurrencyExchangeRateService>();
            services.AddScoped<IFormsService, FormsService>();
            services.AddScoped<IPaymentModeService, PaymentModeService>();
            services.AddScoped<IPaymentTypeService, PaymentTypeService>();
            services.AddScoped<IPayPointsService, PayPointsService>();
            services.AddScoped<IInvoiceTypesService, InvoiceTypesService>();

            services.AddScoped<IModuleCommunicationServices, ModuleCommunicationServices>();

            //// Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

