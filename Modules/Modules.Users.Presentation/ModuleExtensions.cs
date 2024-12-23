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

            services.AddIdentity<ApplicationIdentityUser, ApplicationIdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
            }).AddEntityFrameworkStores<UserDbContext>()
              .AddDefaultTokenProviders();

            services.AddScoped<ValidationService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentUnitService, DepartmentUnitService>();
            services.AddScoped<IAdministrationService, AdministrationService>();
            services.AddScoped<IStaffAccountService, StaffAccountService>();
            services.AddScoped<IPartnerBankAccountService, PartnerBankAccountService>();
            services.AddScoped<ICustomerAccountService, CustomerAccountService>();
            services.AddScoped<IMenuService, MenuService>();

            //register global exception handler
            services.AddExceptionHandler<HttpGlobalExceptionFilter>();
            services.AddProblemDetails();

            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<DepartmentDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<DepartmentUnitDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<TokenStoreDtoValidator>();

            services.AddValidatorsFromAssemblyContaining<RolesDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<RolesUpdateDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<RolesDeleteDtoValidator>();

            services.AddValidatorsFromAssemblyContaining<RoleMenuActionsDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<MenusDtoValidator>();


            //// Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

