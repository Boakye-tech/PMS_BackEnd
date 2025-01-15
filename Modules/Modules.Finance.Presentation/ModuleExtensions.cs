
namespace Modules.Finance.Presentation
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddFinanceModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddFinanceInfrastructure(configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBankBranchService, BankBranchService>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<IBankSortCodesService, BankSortCodesService>();
            services.AddScoped<IChartOfAccountsService, ChartOfAccountsService>();
            services.AddScoped<ICurrencyAndExchangeRateService, CurrencyAndExchangeRateService>();
            services.AddScoped<IFormsService, FormsService>();
            services.AddScoped<IPaymentModeService, PaymentModeService>();
            services.AddScoped<IPaymentTypeService, PaymentTypeService>();
            services.AddScoped<IPayPointsService, PayPointsService>();
            services.AddScoped<IInvoiceTypesService, InvoiceTypesService>();


            //// Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

