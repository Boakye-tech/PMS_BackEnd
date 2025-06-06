// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Extensions/ServiceCollectionExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 1:59 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

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


        //services.AddTransient<IEmailSender, EmailSender>(i => new EmailSender(
        //    config["GmailSender:Host"]!,
        //    config.GetValue<int>("GmailSender:Port"),
        //    config.GetValue<bool>("GmailSender:EnableSSL"),
        //    config["GmailSender:UserName"]!,
        //    config["GmailSender:Password"]!
        //    )
        //);


        return services;
    }
}

