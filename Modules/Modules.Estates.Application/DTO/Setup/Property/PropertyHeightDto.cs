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

public record PropertyHeightReadDto(int propertyHeightId, string propertyHeights);
public record PropertyHeightCreateDto(int propertyHeightId, string propertyHeights, string createdBy);
public record PropertyHeightUpdateDto(int propertyHeightId, string propertyHeights, string modifiedBy);
public record PropertyHeightDeleteDto(int propertyHeightId);
