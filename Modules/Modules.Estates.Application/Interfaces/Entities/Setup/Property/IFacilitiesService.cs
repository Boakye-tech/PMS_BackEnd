// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IFacilitiesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.DTO.Setup.Property;

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IFacilitiesService
{
    Task<ReturnResponsesDto> CreateFacilitiesAsync(FacilitiesCreateDto values);
    Task<ReturnResponsesDto> UpdateFacilitiesAsync(FacilitiesUpdateDto values);
    Task<ReturnResponsesDto> DeleteFacilities(int facilityId);
    Task<IEnumerable<FacilitiesReadDto>> GetFacilitiesAsync();
    Task<FacilitiesReadDto> GetFacilitiesAsync(int value);
    Task<FacilitiesReadDto> GetFacilitiesAsync(string value);
}

