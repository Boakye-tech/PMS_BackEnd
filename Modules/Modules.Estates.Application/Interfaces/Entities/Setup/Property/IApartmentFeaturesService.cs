// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IApartmentFeatures.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/05/2025 4:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
    public interface IApartmentFeaturesService
    {
        Task<ReturnResponsesDto> CreateApartmentFeaturesAsync(ApartmentFeaturesCreateDto values);
        Task<ReturnResponsesDto> UpdateApartmentFeaturesAsync(ApartmentFeaturesUpdateDto values);
        Task<ReturnResponsesDto> DeleteApartmentFeatures(int ApartmentFeaturesId);
        Task<IEnumerable<ApartmentFeaturesReadDto>> GetApartmentFeaturesAsync();

    }
}