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

public record FacilitiesReadDto(int facilityId, string facility);
public record FacilitiesCreateDto(int facilityId, string facility, string createdBy);
public record FacilitiesUpdateDto(int facilityId, string facility, string modifiedBy);
public record FacilitiesDeleteDto(int facilityId);
