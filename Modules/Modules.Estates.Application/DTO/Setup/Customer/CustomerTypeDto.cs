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

public record CustomerTypeReadDto(int customerTypeId, string customerTypes);
public record CustomerTypeCreateDto(int customerTypeId, string customerTypes, string createdBy);
public record CustomerTypeUpdateDto(int customerTypeId, string customerTypes, string modifiedBy);
public record CustomerTypeDeleteDto(int customerTypeId);
