using System;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Notification.Infrastructure.Services;

namespace Modules.Notification.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNotificationInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services
            .AddDbContext<NotificationDbContext>(options => options.UseSqlServer(config.GetConnectionString("MsSQLConnection")));

        services.AddTransient<IEmailSender, EmailSender>(i => new EmailSender(
            config["O356mailSender:Host"]!,
            config.GetValue<int>("O356mailSender:Port"),
            config.GetValue<bool>("O356mailSender:EnableSSL"),
            config["O356mailSender:UserName"]!,
            config["O356mailSender:Password"]!
            )
        );


        return services;
    }
}

