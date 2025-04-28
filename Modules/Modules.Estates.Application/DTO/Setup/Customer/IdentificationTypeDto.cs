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

public record IdentificationTypeReadDto(int identificationTypeId, string identificationTypes);
public record IdentificationTypeCreateDto(int identificationTypeId, string identificationTypes, string createdBy);
public record IdentificationTypeUpdateDto(int identificationTypeId, string identificationTypes, string modifiedBy);
public record IdentificationTypeDeleteDto(int identificationTypeId);


public record IdentificationTypeDto(int identificationTypeId, string identificationTypes);