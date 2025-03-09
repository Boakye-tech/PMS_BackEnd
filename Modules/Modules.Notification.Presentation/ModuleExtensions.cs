

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

            services.AddScoped<ISmsSender, SmsSender>();

            return services;
        }
    }
}

