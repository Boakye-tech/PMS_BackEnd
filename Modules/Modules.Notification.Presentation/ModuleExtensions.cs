// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Modules.Notification.Application.Interfaces;

namespace Modules.Notification.Presentation
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddNotificationModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddNotificationInfrastructure(configuration);

            services.AddMediatR(cfg => cfg.AsTransient(), typeof(SendNotificationHandler).Assembly);

            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<INotificationSender, NotificationService>();
            services.AddScoped<IPushSender, PushNotificationService>();

            services.AddScoped<ISmsSender, SmsSender>();

            return services;
        }
    }
}

