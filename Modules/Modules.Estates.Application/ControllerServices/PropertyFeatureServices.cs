// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/ControllerServices/PropertyFeatureServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 12:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.ControllerServices;

public class PropertyFeatureServices : IPropertyFeatureServices
{
    public IFeaturesService FeaturesService { get; }
    public IApartmentFeaturesService ApartmentFeaturesService { get; }
    public IPlotDimensionService PlotDimensionService { get; }
    public IApartmentTypeService ApartmentTypeService { get; }
    public IPlotTypeService PlotTypeService { get; }
    public IPropertyHeightService PropertyHeightService { get; }
    public ILeaseTypeAndPeriodService LeaseTypeAndPeriodService { get; }

    public PropertyFeatureServices(IFeaturesService featuresService, IApartmentFeaturesService apartmentFeaturesService, IApartmentTypeService apartmentTypeService, IPlotDimensionService plotDimensionService,
                                   IPlotTypeService plotTypeService, IPropertyHeightService propertyHeightService, ILeaseTypeAndPeriodService leaseTypeAndPeriodService)
    {
        FeaturesService = featuresService;
        ApartmentFeaturesService = apartmentFeaturesService;
        ApartmentTypeService = apartmentTypeService;
        PlotDimensionService = plotDimensionService;
        PlotTypeService = plotTypeService;
        PropertyHeightService = propertyHeightService;
        LeaseTypeAndPeriodService = leaseTypeAndPeriodService;
    }

    // Features methods
    public async Task<IEnumerable<FeaturesReadDto>> GetFeaturesAsync() =>
        await FeaturesService.GetFeaturesAsync();
    public async Task<ReturnResponsesDto> CreateFeaturesAsync(FeaturesCreateDto values) =>
        await FeaturesService.CreateFeaturesAsync(values);
    public async Task<ReturnResponsesDto> UpdateFeaturesAsync(FeaturesUpdateDto values) =>
        await FeaturesService.UpdateFeaturesAsync(values);
    public async Task<ReturnResponsesDto> DeleteFeatures(int featureId) =>
        await FeaturesService.DeleteFeatures(featureId);

    // Apartment Features methods
    public async Task<IEnumerable<ApartmentFeaturesReadDto>> GetApartmentFeaturesAsync() =>
        await ApartmentFeaturesService.GetApartmentFeaturesAsync();
    public async Task<ReturnResponsesDto> CreateApartmentFeaturesAsync(ApartmentFeaturesCreateDto values) =>
        await ApartmentFeaturesService.CreateApartmentFeaturesAsync(values);
    public async Task<ReturnResponsesDto> UpdateApartmentFeaturesAsync(ApartmentFeaturesUpdateDto values) =>
        await ApartmentFeaturesService.UpdateApartmentFeaturesAsync(values);
    public async Task<ReturnResponsesDto> DeleteApartmentFeatures(int apartmentFeatureId) =>
        await ApartmentFeaturesService.DeleteApartmentFeatures(apartmentFeatureId);

    // Plot Dimension methods
    public async Task<IEnumerable<PlotDimensionReadDto>> GetPlotDimensionAsync() =>
        await PlotDimensionService.GetPlotDimensionAsync();
    public async Task<PlotDimensionReadDto> GetPlotDimensionAsync(string value) =>
        await PlotDimensionService.GetPlotDimensionAsync(value);
    public async Task<PlotDimensionReadDto> GetPlotDimensionAsync(int plotDimensionId) =>
        await PlotDimensionService.GetPlotDimensionAsync(plotDimensionId);
    public async Task<ReturnResponsesDto> CreatePlotDimensionAsync(PlotDimensionCreateDto values) =>
        await PlotDimensionService.CreatePlotDimensionAsync(values);
    public async Task<ReturnResponsesDto> UpdatePlotDimensionAsync(PlotDimensionUpdateDto values) =>
        await PlotDimensionService.UpdatePlotDimensionAsync(values);
    public async Task<ReturnResponsesDto> DeletePlotDimension(int plotDimensionId) =>
        await PlotDimensionService.DeletePlotDimension(plotDimensionId);

    // Apartment Type methods
    public async Task<IEnumerable<ApartmentTypesReadDto>> GetApartmentTypeAsync() =>
        await ApartmentTypeService.GetApartmentTypeAsync();
    public async Task<ReturnResponsesDto> CreateApartmentTypeAsync(ApartmentTypeCreateDto values) =>
        await ApartmentTypeService.CreateApartmentTypeAsync(values);
    public async Task<ReturnResponsesDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values) =>
        await ApartmentTypeService.UpdateApartmentTypeAsync(values);
    public async Task<ReturnResponsesDto> DeleteApartmentType(int apartmentTypeId) =>
        await ApartmentTypeService.DeleteApartmentType(apartmentTypeId);

    // Plot Type methods
    public async Task<IEnumerable<PlotTypeReadDto>> GetPlotTypeAsync() =>
        await PlotTypeService.GetPlotTypeAsync();
    public async Task<ReturnResponsesDto> CreatePlotTypeAsync(PlotTypeCreateDto values) =>
        await PlotTypeService.CreatePlotTypeAsync(values);
    public async Task<ReturnResponsesDto> UpdatePlotTypeAsync(PlotTypeUpdateDto values) =>
        await PlotTypeService.UpdatePlotTypeAsync(values);
    public async Task<ReturnResponsesDto> DeletePlotType(int PlotTypeId) =>
        await PlotTypeService.DeletePlotType(PlotTypeId);

    // Property Height methods
    public async Task<IEnumerable<PropertyHeightReadDto>> GetPropertyHeightAsync() =>
        await PropertyHeightService.GetPropertyHeightAsync();
    public async Task<ReturnResponsesDto> CreatePropertyHeightAsync(PropertyHeightCreateDto values) =>
        await PropertyHeightService.CreatePropertyHeightAsync(values);
    public async Task<ReturnResponsesDto> UpdatePropertyHeightAsync(PropertyHeightUpdateDto values) =>
        await PropertyHeightService.UpdatePropertyHeightAsync(values);
    public async Task<ReturnResponsesDto> DeletePropertyHeight(int propertyHeightId) =>
        await PropertyHeightService.DeletePropertyHeight(propertyHeightId);

    // Lease Type and Period methods    
    public async Task<IEnumerable<LeaseTypeAndPeriodReadDto>> GetLeaseTypeAndPeriodAsync() =>
        await LeaseTypeAndPeriodService.GetLeaseTypeAndPeriodAsync();
    public async Task<ReturnResponsesDto> CreateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodCreateDto values) =>
        await LeaseTypeAndPeriodService.CreateLeaseTypeAndPeriodAsync(values);
    public async Task<ReturnResponsesDto> UpdateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodUpdateDto values) =>
        await LeaseTypeAndPeriodService.UpdateLeaseTypeAndPeriodAsync(values);
    public async Task<ReturnResponsesDto> DeleteLeaseTypeAndPeriod(int leaseTypeAndPeriodId) =>
        await LeaseTypeAndPeriodService.DeleteLeaseTypeAndPeriod(leaseTypeAndPeriodId);
}
