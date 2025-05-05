// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.DTO.Setup.Customer;

public record ResidentTypeReadDto(int residentTypeId, string residentTypes);
public record ResidentTypeCreateDto(int residentTypeId, string residentTypes,string createdBy);
public record ResidentTypeUpdateDto(int residentTypeId, string residentTypes,string modifiedBy);
public record ResidentTypeDeleteDto(int residentTypeId);
