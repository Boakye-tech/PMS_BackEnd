using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Infrastructure.Extensions;
using Modules.Users.Infrastructure.Repositories;
using Modules.Users.Domain.Interfaces.Entities;
using Modules.Users.Infrastructure.Repositories.Entities;
using System.Threading.RateLimiting;
using Microsoft.AspNetCore.RateLimiting;

namespace Modules.Users.Presentation
{
    /// <summary>
    /// Class to handling all user module extentions. This is needed to enable smooth coordination between the solution and module level presentation layers
    /// </summary>
    /// <remarks>
    /// This controller contains various services and injections needed to run the user module and to handle coordination with the solution level layer.
    /// </remarks>
    /// 
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
            //.AddRoles<ApplicationIdentityRole>()
              .AddDefaultTokenProviders();

            /*
            var key = Encoding.ASCII.GetBytes(configuration["JwTokenKey:TokenKey"]); 
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
            */

            services.AddHttpClient<TokenStoreRepository>();
            services.AddScoped<ValidationService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IChannelService, ChannelService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentUnitService, DepartmentUnitService>();
            services.AddScoped<IAdministrationService, AdministrationService>();
            services.AddScoped<IUserAccountsService, UserAccountsService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<ITokenStoreRepository, TokenStoreRepository>();

            services.AddScoped<IIdentificationTypeService, IdentificationTypeService>();



            //register global exception handler
            services.AddExceptionHandler<HttpGlobalExceptionFilter>();
            services.AddProblemDetails();

            services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblyContaining<ChangePasswordRequestDtoValidator>();


            services.AddValidatorsFromAssemblyContaining<DepartmentDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<DepartmentUnitDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<TokenStoreDtoValidator>();

            services.AddValidatorsFromAssemblyContaining<RolesDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<RolesUpdateDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<RolesDeleteDtoValidator>();

            services.AddValidatorsFromAssemblyContaining<RoleMenuActionsDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<MenusDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<SubMenusDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<SubMenuItemsDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<ApproveUserAccountDtoValidator>();


            services.AddRateLimiter(options =>
            {
                options.AddFixedWindowLimiter("UsersModulePolicy", opt =>
                {
                    opt.Window = TimeSpan.FromMinutes(1);    // Time window of 1 minute
                    opt.PermitLimit = 6;                     // Allow 6 requests per minute
                    opt.QueueLimit = 1;                      // Queue limit of 1
                    opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                });
            });

            //// Dependency Injection - Register AutoMapper 
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            return services;
        }
    }
}

