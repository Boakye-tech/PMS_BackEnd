// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/FormsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record FormsReadDto(string FormCode, string FormName, double Amount, int AccountCode);
public record FormsCreateDto(string? FormCode, string FormName, double Amount, int AccountCode, string CreatedBy);
public record FormsUpdateDto(string FormCode, string FormName, double Amount, int AccountCode, string ModifiedBy);
public record FormsDeleteDto(string FormCode);
