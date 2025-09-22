// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IBankAccountNumbersService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 11:48 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IBankAccountNumbersService
    {
        Task<IEnumerable<BankAccountNumbersReadDto>> GetBankAccountNumbersAsync();

        Task<ReturnResponsesDto> CreateBankAccountNumbersAsync(BankAccountNumbersCreateDto values);

        Task<ReturnResponsesDto> UpdateBankAccountNumbersAsync(BankAccountNumbersUpdateDto values);

        Task<IEnumerable<BankAccountNumbersReadDto>> GetBankAccountNumbersByCriteriaAsync(string searchTerm);
        
        Task<ReturnResponsesDto> DeleteBankAccountNumbersAsync(int bankAccountNumbersId);

        //Task<BankAccountNumbersReadDto> GetBankAccountNumbersAsync(int bankAccountNumbersId);
        //Task<IEnumerable<BankAccountNumbersReadDto>> GetAccountsByBankAndBranchAsync(int bankId, int branchId);
        //Task<IEnumerable<BankAccountNumbersReadDto>> GetAccountsByCurrencyAsync(int currencyId);
    }
}

