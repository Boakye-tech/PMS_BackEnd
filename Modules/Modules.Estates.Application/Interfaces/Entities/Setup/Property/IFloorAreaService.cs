// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IFloorAreaService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IFloorAreaService
{
    Task<ReturnResponsesDto> CreateFloorAreaAsync(FloorAreaCreateDto values);
    Task<ReturnResponsesDto> UpdateFloorAreaAsync(FloorAreaUpdateDto values);
    Task<ReturnResponsesDto> DeleteFloorArea(int facilityId);
    Task<IEnumerable<FloorAreaReadDto>> GetFloorAreaAsync();
    Task<FloorAreaReadDto> GetFloorAreaAsync(int value);
    Task<FloorAreaReadDto> GetFloorAreaAsync(decimal value);
}

