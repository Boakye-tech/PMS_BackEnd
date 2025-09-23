// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/BankAccountNumbersDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 9:58 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Application.Dtos.Setup
{
	public record BankAccountNumbersReadDto(int BankAccountNumbersId,string AccountNumber, string BankId, string BankName, string BranchId, string BranchName, int CurrencyId, string CurrencyName, string Description);

    public record BankAccountNumbersCreateDto(string AccountNumber, string BankId, string BranchId, int CurrencyId, string Description, string CreatedBy);

    public record BankAccountNumbersUpdateDto(int BankAccountNumbersId, string AccountNumber, string BankId, string BranchId, int CurrencyId, string? Description, string ModifiedBy);

    public record BankAccountNumbersDeleteDto(int BankAccountNumbersId);
}

