// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ControllerServices/IPropertySetupServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 7:42 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.ControllerServices
{
	public interface IPropertySetupServices
	{
		// Locality methods
		Task<IEnumerable<LocalityReadDto>> GetLocalityAsync();
		Task<LocalityReadDto> GetLocalityAsync(string value);
		Task<LocalityReadDto> GetLocalityAsync(int localityId);
		Task<ReturnResponsesDto> CreateLocalityAsync(LocalityCreateDto values);
		Task<ReturnResponsesDto> UpdateLocalityAsync(LocalityUpdateDto values);
		Task<ReturnResponsesDto> DeleteLocality(int localityId);

        //Site methods
        Task<IEnumerable<SitesReadDto>> GetSitesAsync();
        Task<ReturnResponsesDto> CreateSiteAsync(SitesCreateDto values);
        Task<ReturnResponsesDto> UpdateSiteAsync(SitesUpdateDto values);
        Task<ReturnResponsesDto> DeleteSite(int siteId);

        //Locality and Sites method
        Task<List<LocalityAndSitesReadDto>> GetLocalityAndSitesAsync();

        // Allocation Type methods
        Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync();
		Task<ReturnResponsesDto> CreateAllocationTypeAsync(AllocationTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteAllocationType(int allocationTypeId);

		// Land Use methods
		Task<IEnumerable<LandUseReadDto>> GetLandUseAsync();
		Task<ReturnResponsesDto> CreateLandUseAsync(LandUseCreateDto values);
		Task<ReturnResponsesDto> UpdateLandUseAsync(LandUseUpdateDto values);
		Task<ReturnResponsesDto> DeleteLandUse(int landUseId);

		// Land Use Type methods
		Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync();
		Task<ReturnResponsesDto> CreateLandUseTypeAsync(LandUseTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteLandUseType(int landUseTypeId);

		// Land Use and Land Use Type method
		Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync();


		//scheme methods
		Task<IEnumerable<SchemeTypeReadDto>> GetSchemeTypeAsync();
		Task<ReturnResponsesDto> CreateSchemeTypeAsync(SchemeTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateSchemeTypeAsync(SchemeTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteSchemeType(int schemeId);

        //apartment category
        Task<IEnumerable<ApartmentCategoryReadDto>> GetApartmentCategoryAsync();
        Task<ReturnResponsesDto> CreateApartmentCategoryAsync(ApartmentCategoryCreateDto values);
        Task<ReturnResponsesDto> UpdateApartmentCategoryAsync(ApartmentCategoryUpdateDto values);
        Task<ReturnResponsesDto> DeleteApartmentCategory(int categoryId);

        // apartment category and apartment type
        Task<List<ApartmentCategoryAndTypesReadDto>> GetApartmentCategoryAndTypesAsync();

    }
}

