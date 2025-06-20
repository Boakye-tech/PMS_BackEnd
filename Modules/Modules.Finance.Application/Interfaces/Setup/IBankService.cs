// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Finance.Application.Dtos.Setup;


namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IBankService
    {
        Task<IEnumerable<BankReadDto>> GetBankAsync();
        Task<BankReadDto> GetBankAsync(string value);
        Task<ReturnResponsesDto> CreateBankAsync(BankCreateDto values);
        Task<ReturnResponsesDto> UpdateBankAsync(BankUpdateDto values);
        Task<ReturnResponsesDto> DeleteBankAsync(string bankId);
    }
}

