// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILandUseTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface ILandUseTypeService
{
    Task<ReturnResponsesDto> CreateLandUseTypeAsync(LandUseTypeCreateDto values);
    Task<ReturnResponsesDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values);
    Task<ReturnResponsesDto> DeleteLandUseType(int landUseTypeId);
    Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync();
    Task<LandUseTypeReadDto> GetLandUseTypeAsync(int value);
    Task<LandUseTypeReadDto> GetLandUseTypeAsync(string value);
}

