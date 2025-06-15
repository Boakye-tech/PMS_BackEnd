// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IPlotTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IPlotTypeService
{
    Task<ReturnResponsesDto> CreatePlotTypeAsync(PlotTypeCreateDto values);
    Task<ReturnResponsesDto> UpdatePlotTypeAsync(PlotTypeUpdateDto values);
    Task<ReturnResponsesDto> DeletePlotType(int PlotTypeId);
    Task<IEnumerable<PlotTypeReadDto>> GetPlotTypeAsync();
    
}

