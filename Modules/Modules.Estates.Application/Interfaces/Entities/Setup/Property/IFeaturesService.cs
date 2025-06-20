// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IFeatures.cs
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
	public interface IFeaturesService
    {
        Task<ReturnResponsesDto> CreateFeaturesAsync(FeaturesCreateDto values);
        Task<ReturnResponsesDto> UpdateFeaturesAsync(FeaturesUpdateDto values);
        Task<ReturnResponsesDto> DeleteFeatures(int FeaturesId);
        Task<IEnumerable<FeaturesReadDto>> GetFeaturesAsync();

    }
}

