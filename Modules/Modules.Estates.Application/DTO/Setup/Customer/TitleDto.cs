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

public record TitleReadDto(int titleId, string titles);
public record TitleCreateDto(int titleId, string titles, string createdby);
public record TitleUpdateDto(int titleId, string titles, string modifiedby);
public record TitleDeleteDto(int titleId);
