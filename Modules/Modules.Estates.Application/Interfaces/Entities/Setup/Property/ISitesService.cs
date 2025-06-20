// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ISitesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 10:34 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface ISitesService
	{
        Task<ReturnResponsesDto> CreateSitesAsync(SitesCreateDto values);
        Task<ReturnResponsesDto> UpdateSitesAsync(SitesUpdateDto values);
        Task<ReturnResponsesDto> DeleteSites(int siteId);
        Task<IEnumerable<SitesReadDto>> GetSitesAsync();

    }
}

