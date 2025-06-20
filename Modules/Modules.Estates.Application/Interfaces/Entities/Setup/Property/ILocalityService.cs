// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILocalityService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface ILocalityService
{
    Task<ReturnResponsesDto> CreateLocalityAsync(LocalityCreateDto values);
    Task<ReturnResponsesDto> UpdateLocalityAsync(LocalityUpdateDto values);
    Task<ReturnResponsesDto> DeleteLocality(int localityId);
    Task<IEnumerable<LocalityReadDto>> GetLocalityAsync();
    Task<LocalityReadDto> GetLocalityAsync(int value);
    Task<LocalityReadDto> GetLocalityAsync(string value);

    Task<List<LocalityAndSitesReadDto>> GetLocalityAndSitesAsync();
}

