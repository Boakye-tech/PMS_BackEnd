// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILandUseService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 1:06 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
    public interface ILandUseService
    {
        Task<ReturnResponsesDto> CreateLandUseAsync(LandUseCreateDto values);
        Task<ReturnResponsesDto> UpdateLandUseAsync(LandUseUpdateDto values);
        Task<IEnumerable<LandUseReadDto>> GetLandUseAsync();
        Task<LandUseReadDto> GetLandUseAsync(int value);
        Task<LandUseReadDto> GetLandUseAsync(string value);
        Task<ReturnResponsesDto> DeleteLandUse(int landUseId);

        Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync();
    }
}

