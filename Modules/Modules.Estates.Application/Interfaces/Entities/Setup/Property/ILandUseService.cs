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

public interface ILandUseService
{
	Task<LandUseReadDto> AddLandUseAsync(LandUseCreateDto values);
    Task<LandUseReadDto> UpdateLandUseAsync(LandUseUpdateDto values);
    Task<IEnumerable<LandUseReadDto>> GetLandUseAsync();
    Task<LandUseReadDto> GetLandUseAsync(int value);
    Task<LandUseReadDto> GetLandUseAsync(string value);
}

