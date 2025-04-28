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

public record GenderReadDto(int genderId, string genderType);
public record GenderCreateDto(int genderId, string genderType, string createdBy);
public record GenderUpdateDto(int genderId, string genderType, string modifiedBy);
public record GenderDeleteDto(int genderId);
