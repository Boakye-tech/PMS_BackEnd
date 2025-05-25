// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILandUseAndLandUseTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 10:32 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface ILandUseAndLandUseTypeService
	{
        Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync();
    }
}

