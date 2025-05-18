// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record FloorAreaReadDto(int floorAreaId, decimal area);
public record FloorAreaCreateDto(decimal area, string createdBy);
public record FloorAreaUpdateDto(int floorAreaId, decimal area, string modifiedBy);
public record FloorAreaDeleteDto(int floorAreaId);
