// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/ChartOfAccountsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record ChartOfAccountsReadDto(int AccountCode, string AccountName);
public record ChartOfAccountsCreateDto(int AccountCode, string AccountName, string CreatedBy);
public record ChartOfAccountsUpdateDto(int AccountCode, string AccountName, string ModifiedBy);
public record ChartOfAccountsDeleteDto(int AccountCode);
