// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using FluentValidation;
using Modules.Estates.Application.ControllerServices;

namespace Modules.Estates.Presentation;

public static class ModuleExtensions
{
    public static IServiceCollection AddEstateModule(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
    {
        services
            //.AddCatalogCore()
            .AddEstateInfrastructure(configuration, environment);

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IAllocationTypeService, AllocationTypeService>();
        services.AddScoped<IApartmentTypeService, ApartmentTypeService>();
        services.AddScoped<IBlockNumberService, BlockNumberService>();
        services.AddScoped<IBlockSideService, BlockSideService>();
        services.AddScoped<IBlockTypeService, BlockTypeService>();
        services.AddScoped<IBlockUnitService, BlockUnitService>();
        services.AddScoped<IFloorAreaService, FloorAreaService>();
        services.AddScoped<IFloorNumberingService, FloorNumberingService>();
        services.AddScoped<ILandUseService, LandUseService>();
        services.AddScoped<ILandUseTypeService, LandUseTypeService>();
        services.AddScoped<ILocalityService, LocalityService>();
        services.AddScoped<IPlotDimensionService, PlotDimensionService>();
        services.AddScoped<IPropertyHeightService, PropertyHeightService>();
        services.AddScoped<IPlotTypeService, PlotTypeService>();

        services.AddScoped<ILeaseTypeAndPeriodService, LeaseTypeAndPeriodService>();
        services.AddScoped<IPropertyStatusService, PropertyStatusService>();

        services.AddScoped<IActivityService, ActivityService>();
        services.AddScoped<IActivityTypeService, ActivityTypeService>();

        services.AddScoped<IPropertyMasterService, PropertyMasterService>();
        services.AddScoped<ICustomerDomainService, CustomerDomainService>();

        services.AddScoped<ICustomerTypeService, CustomerTypeService>();
        services.AddScoped<IGenderService, GenderService>();
        services.AddScoped<IIdentificationTypeService, IdentificationTypeService>();
        services.AddScoped<INationalityService, NationalityService>();
        services.AddScoped<IResidentTypeService, ResidentTypeService>();
        services.AddScoped<ISocialMediaService, SocialMediaService>();
        services.AddScoped<ITitleService, TitleService>();
        services.AddScoped<IOwnershipTypeService, OwnershipTypeService>();

        services.AddScoped<ICustomerMasterService, CustomerMasterService>();

        services.AddScoped<IDomainEventDispatcher, DomainEventDispatcher>();

        services.AddScoped<IInterestExpressedService, InterestExpressedService>();

        services.AddScoped<IIdentificationTypeService, IdentificationTypeService>();
        services.AddHttpClient<IModuleCommunicationServices, ModuleCommunicationServices>();

        services.AddScoped<IComplaintTypeService, ComplaintTypeService>();
        services.AddScoped<INatureOfComplaintService, NatureOfComplaintService>();
        services.AddScoped<IComplaintMasterService, ComplaintMasterService>();
        services.AddScoped<IComplaintStatusesService, ComplaintStatusesService>();

        services.AddScoped<IFeaturesService, FeaturesService>();
        services.AddScoped<IApartmentFeaturesService, ApartmentFeaturesService>();

        services.AddScoped<ICurrencyExchangeRateService, CurrencyExchangeRateService>();

        services.AddScoped<IRentalCategoryService, RentalCategoryService>();
        services.AddScoped<IRentalTypeService, RentalTypeService>();
        services.AddScoped<IShopOfficeTypesService, ShopOfficeTypesService>();
        services.AddScoped<IHouseTypesService, HouseTypesService>();

        services.AddScoped<ISitesService, SitesService>();
        services.AddScoped<ISchemeTypeService, SchemeTypeService>();
        services.AddScoped<IApartmentCategoryService, ApartmentCategoryService>();


        services.AddScoped<ITypesService, TypesService>();
        services.AddScoped<IActivityServices, ActivityServices>();
        services.AddScoped<IBlockServices, BlockServices>();
        services.AddScoped<IRentalsServices, RentalsServices>();
        services.AddScoped<IPropertyFeatureServices, PropertyFeatureServices>();
        services.AddScoped<IPropertySetupServices, PropertySetupServices>();

        services.AddValidatorsFromAssemblyContaining<CustomerTypeDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<GenderDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<IdentificationTypeDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<NationalityDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<OwnershipTypeDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<ResidentTypeDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<SocialMediaDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<TitleDtoValidator>();
        services.AddValidatorsFromAssemblyContaining<InterestExpressedDtoValidator>();

        // Dependency Injection - Register AutoMapper 
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


        return services;
    }
}

