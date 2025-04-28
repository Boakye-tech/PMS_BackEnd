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

public record OwnershipTypeReadDto(int ownershipTypeId, string ownershipTypes);
public record OwnershipTypeCreateDto(int ownershipTypeId, string ownershipTypes, string createdby);
public record OwnershipTypeUpdateDto(int ownershipTypeId, string ownershipTypes, string modifiedby);
public record OwnershipTypeDeleteDto(int ownershipTypeId);

