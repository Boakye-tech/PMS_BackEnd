// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/AllocationTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record AllocationTypeReadDto(int AllocationTypeId, string AllocationTypeInitial, string AllocationTypes);
public record AllocationTypeCreateDto(string AllocationTypeInitial, string AllocationTypes, string CreatedBy);
public record AllocationTypeUpdateDto(int AllocationTypeId, string AllocationTypeInitial, string AllocationTypes, string ModifiedBy);
public record AllocationTypeDeleteDto(int AllocationTypeId);
