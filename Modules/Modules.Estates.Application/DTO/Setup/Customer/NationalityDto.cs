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

public record NationalityReadDto(int nationalityId, string nationalities);
public record NationalityCreateDto(int nationalityId, string nationalities, string createdby);
public record NationalityUpdateDto(int nationalityId, string nationalities, string modifiedby);
public record NationalityDeleteDto(int nationalityId);
