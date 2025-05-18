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
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Modules.Notification.Infrastructure.Services;

namespace Modules.Notification.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNotificationInfrastructure(this IServiceCollection services, IConfiguration config, IHostEnvironment env)
    {
        string? connectionString = null!;

        if (env.IsDevelopment())
        {
            connectionString = config.GetConnectionString("MsSQLConnection_Development");
        }

        if (env.IsStaging())
        {
            connectionString = config.GetConnectionString("MsSQLConnection_Staging");
        }

        if (env.IsProduction())
        {
            connectionString = config.GetConnectionString("MsSQLConnection");
        }

        services
            .AddDbContext<NotificationDbContext>(options => options.UseSqlServer(connectionString));

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

