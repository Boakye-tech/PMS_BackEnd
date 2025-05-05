// /**************************************************
// * Company: MindSprings Company Limited
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
    Task<LandUseTypeReadDto> AddLandUseTypeAsync(LandUseTypeCreateDto values);
    Task<LandUseTypeReadDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values);
    Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync();
    Task<LandUseTypeReadDto> GetLandUseTypeAsync(int value);
    Task<LandUseTypeReadDto> GetLandUseTypeAsync(string value);
}

