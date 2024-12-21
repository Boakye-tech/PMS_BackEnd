using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IBankBranchService
	{
        Task<BankBranchReadDto> CreateBankBranchAsync(BankBranchCreateDto values);
        Task<BankBranchReadDto> UpdateBankBranchAsync(BankBranchUpdateDto values);
        Task<IEnumerable<BankBranchReadDto>> GetBankBranchAsync();
        Task<BankBranchReadDto> GetBankBranchAsync(int value);
        Task<BankBranchReadDto> GetBankBranchAsync(string value);
    }
}

