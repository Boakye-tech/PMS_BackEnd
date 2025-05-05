// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IBankSortCodesService
	{
        Task<BankSortCodesReadDto> AddBankSortCodesAsync(BankSortCodesCreateDto values);
        Task<BankSortCodesReadDto> UpdateBankSortCodesAsync(BankSortCodesUpdateDto values);
        Task<IEnumerable<BankSortCodesReadDto>> GetBankSortCodesAsync();
        Task<BankSortCodesReadDto> GetBankSortCodesAsync(int value);
        Task<BankSortCodesReadDto> GetBankSortCodesAsync(string value);
    }
}

