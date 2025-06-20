// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/BankSortCodesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record BankSortCodesReadDto(int Id, string SortCode, string BankName, string BranchName);
public record BankSortCodesCreateDto(int Id, string SortCode, string BankName, string BranchName, string CreatedBy);
public record BankSortCodesUpdateDto(int Id, string SortCode, string BankName, string BranchName, string ModifiedBy);
public record BankSortCodesDeleteDto(int Id);
