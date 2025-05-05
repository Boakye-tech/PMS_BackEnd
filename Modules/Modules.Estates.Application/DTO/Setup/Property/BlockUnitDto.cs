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

public record BlockUnitReadDto(int unitId, string unit);
public record BlockUnitCreateDto(int unitId, string unit, string createdby);
public record BlockUnitUpdateDto(int unitId, string unit, string modifiedby);
public record BlockUnitDeleteDto(int unitId);


