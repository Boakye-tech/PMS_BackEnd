// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IPlotFeaturesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 1:32 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IPlotFeaturesService
	{
        Task<ReturnResponsesDto> CreatePlotFeaturesAsync(PlotFeaturesCreateDto values);
        Task<ReturnResponsesDto> UpdatePlotFeaturesAsync(PlotFeaturesUpdateDto values);
        Task<ReturnResponsesDto> DeletePlotFeatures(int plotTypeId, int featureId);
        Task<IEnumerable<PlotFeaturesReadDto>> GetPlotFeaturesAsync();

    }
}

