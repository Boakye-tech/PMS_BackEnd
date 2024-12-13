using System;
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

