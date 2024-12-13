using System;
using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
using Modules.Estates.Application.Repositories.Setup.Property;
using Modules.Estates.Domain;
using Modules.Estates.Infrastructure.UnitOfWork;
using PMS.Presentation.Controllers;

namespace PMS.Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers()
            .ConfigureApplicationPartManager(manager =>
            {
                manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
            });

        return services;
    }
}

