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

public record BlockTypeReadDto(int blockTypeId, string blockType);
public record BlockTypeCreateDto(int blockTypeId, string blockType, string createdby);
public record BlockTypeUpdateDto(int blockTypeId, string blockType, string modifiedby);
public record BlockTypeDeleteDto(int blockTypeId);
