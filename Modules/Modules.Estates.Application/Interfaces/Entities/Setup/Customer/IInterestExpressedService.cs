using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface IInterestExpressedService
	{
        Task<InterestExpressedReadDto> CreateInterestExpressedAsync(InterestExpressedCreateDto values);
        Task<InterestExpressedReadDto> UpdateInterestExpressedAsync(InterestExpressedUpdateDto values);
        Task<IEnumerable<InterestExpressedReadDto>> GetInterestExpressedAsync();
        Task<string> DeleteInterestExpressedAsync(int value);
    }
}

