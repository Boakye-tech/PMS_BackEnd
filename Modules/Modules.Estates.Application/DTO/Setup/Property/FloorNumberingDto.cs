// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/FloorNumberingDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record FloorNumberingReadDto(int floorNumberId, string floorNumber);
public record FloorNumberingCreateDto(string floorNumber, string createdby);
public record FloorNumberingUpdateDto(int floorNumberId, string floorNumber, string modifiedby);
public record FloorNumberingDeleteDto(int floorNumberId);
