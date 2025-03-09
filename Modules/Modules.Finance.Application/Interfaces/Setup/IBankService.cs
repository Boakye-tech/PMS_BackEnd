using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IBankService
	{
        Task<BankReadDto> AddBankAsync(BankCreateDto values);
        Task<BankReadDto> UpdateBankAsync(BankUpdateDto values);
        Task<IEnumerable<BankReadDto>> GetBankAsync();
        Task<BankReadDto> GetBankAsync(int value);
        Task<BankReadDto> GetBankAsync(string value);
    }
}

