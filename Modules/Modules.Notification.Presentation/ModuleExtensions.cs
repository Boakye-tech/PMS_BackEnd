// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/ModuleExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Notification.Application.Interfaces;
using Modules.Notification.Presentation.Hubs;

namespace Modules.Notification.Presentation
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddNotificationModule(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services
                .AddNotificationInfrastructure(configuration, environment);

            services.AddMediatR(cfg => cfg.AsTransient(), typeof(SendNotificationHandler).Assembly);

            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<INotificationSender, NotificationService>();
            services.AddScoped<IPushSender, PushNotificationService>();
            services.AddScoped<ISmsSender, SmsSender>();
            services.AddScoped<ISignalRNotificationService, SignalRNotificationService>();

            // Add SignalR
            services.AddSignalR(options =>
            {
                options.EnableDetailedErrors = environment.IsDevelopment();
                options.MaximumReceiveMessageSize = 102400; // 100 KB
            });

            return services;
        }

        public static IEndpointRouteBuilder MapNotificationEndpoints(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapHub<NotificationHub>("/hubs/notifications");
            return endpoints;
        }
    }
}

