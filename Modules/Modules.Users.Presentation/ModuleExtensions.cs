using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Infrastructure.Extensions;
using Modules.Users.Infrastructure.Repositories;
using Modules.Users.Domain.Interfaces.Entities;
using Modules.Users.Infrastructure.Repositories.Entities;

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

                //password settings
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 1;

                //lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = true;

                //user settiings
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters ="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            }).AddEntityFrameworkStores<UserDbContext>()
              .AddDefaultTokenProviders();


            //var key = Encoding.ASCII.GetBytes(configuration["JwTokenKey:TokenKey"]); 
            var key = Encoding.ASCII.GetBytes(configuration.GetSection("JwTokenKey").GetSection("TokenKey").Value!);

            services.AddAuthentication(a =>
            {
                a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                a.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = ApplicationDbContext =>
                    {
                        //TODO
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

            });


            services.AddScoped<ValidationService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentUnitService, DepartmentUnitService>();
            services.AddScoped<IAdministrationService, AdministrationService>();
            services.AddScoped<IStaffAccountService, StaffAccountService>();
            services.AddScoped<IPartnerBankAccountService, PartnerBankAccountService>();
            services.AddScoped<ICustomerAccountService, CustomerAccountService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<ITokenStoreRepository, TokenStoreRepository>();


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

