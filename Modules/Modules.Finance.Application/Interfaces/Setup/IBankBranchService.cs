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
	public interface IBankBranchService
	{
        Task<BankBranchReadDto> CreateBankBranchAsync(BankBranchCreateDto values);
        Task<BankBranchReadDto> UpdateBankBranchAsync(BankBranchUpdateDto values);
        Task<IEnumerable<BankBranchReadDto>> GetBankBranchAsync();
        Task<BankBranchReadDto> GetBankBranchAsync(int value);
        Task<BankBranchReadDto> GetBankBranchAsync(string value);
    }
}

