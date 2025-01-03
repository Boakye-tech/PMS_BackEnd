﻿using System;
using Modules.Estates.Application.Interfaces.Management.Property;
using Modules.Estates.Application.Repositories.Management;
using Modules.Estates.Infrastructure.Extensions;

namespace Modules.Estates.Presentation;

public static class ModuleExtensions
{
    public static IServiceCollection AddEstateModule(this IServiceCollection services, IConfiguration configuration)
    {
        services
            //.AddCatalogCore()
            .AddEstateInfrastructure(configuration);

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAllocationTypeService, AllocationTypeService>();
        services.AddScoped<IApartmentTypeService, ApartmentTypeService>();
        services.AddScoped<IBlockNumberService, BlockNumberService>();
        services.AddScoped<IBlockSideService, BlockSideService>();
        services.AddScoped<IBlockTypeService, BlockTypeService>();
        services.AddScoped<IBlockUnitService, BlockUnitService>();
        services.AddScoped<IFacilitiesService, FacilitiesService>();
        services.AddScoped<IFloorNumberingService, FloorNumberingService>();
        services.AddScoped<ILandUseService, LandUseService>();
        services.AddScoped<ILandUseTypeService, LandUseTypeService>();
        services.AddScoped<ILocalityService, LocalityService>();
        services.AddScoped<IPlotSizeService, PlotSizeService>();
        services.AddScoped<IPropertyHeightService, PropertyHeightService>();
        services.AddScoped<IPropertyTypeService, PropertyTypeService>();

        services.AddScoped<IActivityService, ActivityService>();
        services.AddScoped<IActivityTypeService, ActivityTypeService>();

        services.AddScoped<IPropertyMasterService, PropertyMasterService>();


        services.AddScoped<ICustomerTypeService, CustomerTypeService>();
        services.AddScoped<IGenderService, GenderService>();
        services.AddScoped<IIdentificationTypeService, IdentificationTypeService>();
        services.AddScoped<INationalityService, NationalityService>();
        services.AddScoped<IResidentTypeService, ResidentTypeService>();
        services.AddScoped<ISocialMediaService, SocialMediaService>();
        services.AddScoped<ITitleService, TitleService>();

        // Dependency Injection - Register AutoMapper 
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


        return services;
    }
}

