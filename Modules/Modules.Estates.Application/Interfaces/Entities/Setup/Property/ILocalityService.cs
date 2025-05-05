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

public interface ILocalityService
{
    Task<LocalityReadDto> CreateLocalityAsync(LocalityCreateDto values);
    Task<LocalityReadDto> UpdateLocalityAsync(LocalityUpdateDto values);
    Task<IEnumerable<LocalityReadDto>> GetLocalityAsync();
    Task<LocalityReadDto> GetLocalityAsync(int value);
    Task<LocalityReadDto> GetLocalityAsync(string value);
    Task<string> DeleteLocality(int localityId);
}

