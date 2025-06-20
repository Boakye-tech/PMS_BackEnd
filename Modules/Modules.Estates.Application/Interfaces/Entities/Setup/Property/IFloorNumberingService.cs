// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IFloorNumberingService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IFloorNumberingService
{
    Task<ReturnResponsesDto> CreateFloorNumberingAsync(FloorNumberingCreateDto values);
    Task<ReturnResponsesDto> UpdateFloorNumberingAsync(FloorNumberingUpdateDto values);
    Task<ReturnResponsesDto> DeleteFloorNumbering(int floorNumberId);
    Task<IEnumerable<FloorNumberingReadDto>> GetFloorNumberingAsync();
    Task<FloorNumberingReadDto> GetFloorNumberingAsync(int value);
    Task<FloorNumberingReadDto> GetFloorNumberingAsync(string value);
}

