// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/ControllerServices/PropertySetupServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 12:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
using Modules.Estates.Application.UseCases.Setup.Property;

namespace Modules.Estates.Application.ControllerServices;

public class PropertySetupServices : IPropertySetupServices
{
    public ILocalityService LocalityService { get; }
    public ISitesService SitesService { get; }

    public IAllocationTypeService AllocationTypeService { get; }

    public ILandUseService LandUseService { get; }
    public ILandUseTypeService LandUseTypeService { get; }

    public ISchemeTypeService SchemeTypeService { get; }

    public IApartmentCategoryService ApartmentCategoryService  { get; }

    public PropertySetupServices(IAllocationTypeService allocationTypeService, ILocalityService localityService,ISitesService sitesService, ILandUseService landUseService, ILandUseTypeService landUseTypeService, ISchemeTypeService schemeTypeService, IApartmentCategoryService apartmentCategoryService)
    {
        AllocationTypeService = allocationTypeService;

        LocalityService = localityService;
        SitesService = sitesService;

        LandUseService = landUseService;
        LandUseTypeService = landUseTypeService;

        SchemeTypeService = schemeTypeService;

        ApartmentCategoryService = apartmentCategoryService;
    }

    // Locality methods
    public async Task<IEnumerable<LocalityReadDto>> GetLocalityAsync() =>
        await LocalityService.GetLocalityAsync();

    public async Task<LocalityReadDto> GetLocalityAsync(string value) =>
        await LocalityService.GetLocalityAsync(value);

    public async Task<LocalityReadDto> GetLocalityAsync(int localityId) =>
        await LocalityService.GetLocalityAsync(localityId);

    public async Task<ReturnResponsesDto> CreateLocalityAsync(LocalityCreateDto values) =>
        await LocalityService.CreateLocalityAsync(values);

    public async Task<ReturnResponsesDto> UpdateLocalityAsync(LocalityUpdateDto values) =>
        await LocalityService.UpdateLocalityAsync(values);

    public async Task<ReturnResponsesDto> DeleteLocality(int localityId) =>
        await LocalityService.DeleteLocality(localityId);


    public async Task<List<LocalityAndSitesReadDto>> GetLocalityAndSitesAsync() =>
        await LocalityService.GetLocalityAndSitesAsync();

    //Allocation type methods
    public async Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync() =>
        await AllocationTypeService.GetAllocationTypeAsync();

    public async Task<AllocationTypeReadDto> GetAllocationTypeAsync(string allocationType) =>
        await AllocationTypeService.GetAllocationTypeAsync(allocationType);

    public async Task<AllocationTypeReadDto> GetAllocationTypeAsync(int allocationTypeId) =>
        await AllocationTypeService.GetAllocationTypeAsync(allocationTypeId);

    public async Task<ReturnResponsesDto> CreateAllocationTypeAsync(AllocationTypeCreateDto values) =>
        await AllocationTypeService.CreateAllocationTypeAsync(values);

    public async Task<ReturnResponsesDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values) =>
        await AllocationTypeService.UpdateAllocationTypeAsync(values);

    public async Task<ReturnResponsesDto> DeleteAllocationType(int allocationTypeId) =>
        await AllocationTypeService.DeleteAllocationType(allocationTypeId);



    // Land Use methods
    public async Task<IEnumerable<LandUseReadDto>> GetLandUseAsync() =>
        await LandUseService.GetLandUseAsync();

    public async Task<LandUseReadDto> GetLandUseAsync(string landUse) =>
        await LandUseService.GetLandUseAsync(landUse);

    public async Task<LandUseReadDto> GetLandUseAsync(int landUseId) =>
        await LandUseService.GetLandUseAsync(landUseId);

    public async Task<ReturnResponsesDto> CreateLandUseAsync(LandUseCreateDto values) =>
        await LandUseService.CreateLandUseAsync(values);

    public async Task<ReturnResponsesDto> UpdateLandUseAsync(LandUseUpdateDto values) =>
        await LandUseService.UpdateLandUseAsync(values);

    public async Task<ReturnResponsesDto> DeleteLandUse(int landUseId) =>
        await LandUseService.DeleteLandUse(landUseId);

    public async Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync() =>
        await LandUseService.GetLandUseAndLandUseTypeAsync();

    // Land Use Type methods
    public async Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync() =>
        await LandUseTypeService.GetLandUseTypeAsync();

    public async Task<LandUseTypeReadDto> GetLandUseTypeAsync(string landUse) =>
        await LandUseTypeService.GetLandUseTypeAsync(landUse);

    public async Task<LandUseTypeReadDto> GetLandUseTypeAsync(int landUseTypeId) =>
        await LandUseTypeService.GetLandUseTypeAsync(landUseTypeId);

    public async Task<ReturnResponsesDto> CreateLandUseTypeAsync(LandUseTypeCreateDto values) =>
        await LandUseTypeService.CreateLandUseTypeAsync(values);

    public async Task<ReturnResponsesDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values) =>
        await LandUseTypeService.UpdateLandUseTypeAsync(values);

    public async Task<ReturnResponsesDto> DeleteLandUseType(int landUseTypeId) =>
        await LandUseTypeService.DeleteLandUseType(landUseTypeId);


    //Sites methods
    public async Task<IEnumerable<SitesReadDto>> GetSitesAsync() =>
        await SitesService.GetSitesAsync();

    public async Task<ReturnResponsesDto> CreateSiteAsync(SitesCreateDto values) =>
        await SitesService.CreateSitesAsync(values);

    public async Task<ReturnResponsesDto> UpdateSiteAsync(SitesUpdateDto values) =>
        await SitesService.UpdateSitesAsync(values);

    public async Task<ReturnResponsesDto> DeleteSite(int siteId) =>
        await SitesService.DeleteSites(siteId);

    //scheme methods
    public async Task<IEnumerable<SchemeTypeReadDto>> GetSchemeTypeAsync() =>
        await SchemeTypeService.GetSchemeTypeAsync();

    public async Task<ReturnResponsesDto> CreateSchemeTypeAsync(SchemeTypeCreateDto values) =>
        await SchemeTypeService.CreateSchemeTypeAsync(values);

    public async Task<ReturnResponsesDto> UpdateSchemeTypeAsync(SchemeTypeUpdateDto values) =>
        await SchemeTypeService.UpdateSchemeTypeAsync(values);

    public async Task<ReturnResponsesDto> DeleteSchemeType(int schemeId) =>
        await SchemeTypeService.DeleteSchemeType(schemeId);


    //apartment category methods
    public async Task<IEnumerable<ApartmentCategoryReadDto>> GetApartmentCategoryAsync() =>
        await ApartmentCategoryService.GetApartmentCategoryAsync();

    public async Task<ReturnResponsesDto> CreateApartmentCategoryAsync(ApartmentCategoryCreateDto values) =>
        await ApartmentCategoryService.CreateApartmentCategoryAsync(values);

    public async Task<ReturnResponsesDto> UpdateApartmentCategoryAsync(ApartmentCategoryUpdateDto values) =>
        await ApartmentCategoryService.UpdateApartmentCategoryAsync(values);

    public async Task<ReturnResponsesDto> DeleteApartmentCategory(int categoryId) =>
        await ApartmentCategoryService.DeleteApartmentCategory(categoryId);

    public async Task<List<ApartmentCategoryAndTypesReadDto>> GetApartmentCategoryAndTypesAsync() =>
        await ApartmentCategoryService.GetApartmentCategoryAndTypesAsync();

}