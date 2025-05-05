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

public record PropertyTypeReadDto(int PropertyTypeId, string PropertyTypes);
public record PropertyTypeCreateDto(int PropertyTypeId, string PropertyTypes, string CreatedBy);
public record PropertyTypeUpdateDto(int PropertyTypeId, string PropertyTypes, string ModifiedBy);
public record PropertyTypeDeleteDto(int PropertyTypeId);
