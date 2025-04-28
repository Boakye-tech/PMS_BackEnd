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

public record BlockNumberReadDto(int blockNumberId, string blockNumbers);
public record BlockNumberCreateDto(int blockNumberId, string blockNumbers, string createdby);
public record BlockNumberUpdateDto(int blockNumberId, string blockNumbers, string modifiedby);
public record BlockNumberDeleteDto(int blockNumberId);
